var system = require('system');

var appArgs = getArgs();

var page = require("webpage").create();
page.settings.userAgent = 'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2062.120 Safari/537.36';

var width = 1000;
var height = 600;

page.viewportSize = { width: width, height: height };

console.log('try open url');
page.open(appArgs.mapUrl, function (status) {

    console.log('Open Page Status: ' + status);

    if (status == 'fail') {
        console.log('fail');
        phantom.exit();
    }

    // suggested here https://stackoverflow.com/questions/13390859/viewportsize-seems-not-to-work-with-phantomjs
    page.evaluate(function (w, h) {
        document.body.style.width = w + "px";
        document.body.style.height = h + "px";
    }, width, height);

    var frameIndex = 1;
    var date = new Date();
    trackMapStates();

    function trackMapStates() {
        var secondsFromStart = (new Date() - date) / 1000;

        if (secondsFromStart >= appArgs.timeoutInSeconds) {
            console.log('oops! timeout (' + appArgs.timeoutInSeconds + ' seconds)');
            phantom.exit();
        }

        var animationState = page.evaluate(function () {
            var el = document.getElementById('completestate');
            return el && el.innerHTML.trim();
        });

        switch (animationState) {
            case 'start':
                page.evaluate(function () {
                    moveMarker();
                });
                try {
                    page.clipRect = { top: 0, left: 0, width: width, height: height };
                    page.render(appArgs.outputPath + "/capture" + pad(frameIndex, 9) + ".png", { format: "png", quality: '30' });
                    console.log('Captured frame ' + frameIndex);
                    frameIndex++;
                } catch (rendererr) {
                    console.log('Error during capture render', rendererr);
                }
                setTimeout(function () {
                    trackMapStates();
                }, 0);
                break;

            case 'yes':
                console.log('Image capture complete');
                phantom.exit();
                break;

            default:
                console.log('map not loaded yet', formatDate(new Date()));
                setTimeout(function () {
                    trackMapStates();
                }, 1000);
                break;
        }
    }
});

function getArgs() {
    var args = system.args;

    var outputPath = args[1];
    var mapUrl = args[2];
    var timeoutInSeconds = args[3];

    if (!outputPath) {
        console.log('fail: output path not specified');
        phantom.exit();
    }

    if (!mapUrl) {
        console.log('fail: map URL not specified');
        phantom.exit();
    }

    if (!timeoutInSeconds) {
        console.log('fail: processing timeout not specified');
        phantom.exit();
    }

    return {
        outputPath: outputPath,
        mapUrl: mapUrl,
        timeoutInSeconds: timeoutInSeconds
    };
}

function pad(num, size) {
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
}

function formatDate(m) {
    return ("0" + m.getUTCHours()).slice(-2) + ":" +
        ("0" + m.getUTCMinutes()).slice(-2) + ":" +
        ("0" + m.getUTCSeconds()).slice(-2) + ":" +
        m.getUTCMilliseconds();
}