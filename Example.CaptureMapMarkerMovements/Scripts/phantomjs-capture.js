var system = require('system');

var appArgs = getArgs();

var page = require("webpage").create();
page.settings.userAgent = 'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2062.120 Safari/537.36';

var timeoutInSeconds = 120;
var width = 1100;
var height = 700;
// TODO :: seems not works
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

        if (secondsFromStart >= timeoutInSeconds) {
            console.log('timeout');
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
                //trackMapStates();
                break;

            case 'yes':
                console.log('done');
                phantom.exit();
                break;

            default:
                console.log('map not loaded yet', new Date());
                setTimeout(function () {
                    trackMapStates();
                }, 1000);
                break;
        }
    }
    //page.clipRect = {top: 0, left: 0, width: width, height: height};
});

function getArgs() {
    var args = system.args;

    var outputPath = args[1];
    var mapUrl = args[2];

    if (!outputPath) {
        console.log('fail: output path not specified');
        phantom.exit();
    }

    if (!mapUrl) {
        console.log('fail: map URL not specified');
        phantom.exit();
    }

    return {
        outputPath: outputPath,
        mapUrl: mapUrl
    };
}

function pad(num, size) {
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
}