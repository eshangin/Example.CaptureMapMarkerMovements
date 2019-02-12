var bingMapsKey = 'AifUA41UximrujvNoJp15-yQsmBOattJxjecWXdsW4fzIDr14uBd0-xvZykxDoAq';

var inputData = JSON.parse(document.getElementById('input-data').innerText);

var wp = parseWaypoints(inputData);

var mapInfo = initializeMap();

var currentCarWaypointIndex = 0;
var intermidiateWaypointsToOriginalDataHash = {};
var waypointsWithIntermidiate = calculateIntermidiatePoints();
var isManualAnimation = false;
var manualAnimationTimeout = null;

console.log('TOTAL WAYPOINTS', waypointsWithIntermidiate.length);

// This function will be called by PhantomJS script
function moveMarker() {

    var waypoints = waypointsWithIntermidiate;

    if (currentCarWaypointIndex >= waypoints.length) {
        stopAnimation();
        return;
    }

    var waypointCoords = waypoints[currentCarWaypointIndex];
    var waypointData = intermidiateWaypointsToOriginalDataHash[waypointCoords[0] + waypointCoords[1]];
    var text = 'Date: ' + waypointData.Date + '<br/>Speed: ' + waypointData.Speed;
    mapInfo.carMarker.getStyle().setText(createTextStyle(waypointData.DeviceName));
    mapInfo.carMarker.getGeometry().setCoordinates(waypointCoords);

    updateOverlay(mapInfo.overlay, waypointCoords, text);

    currentCarWaypointIndex += 1;
}

function readyToStartAnimation() {
    document.getElementById('completestate').innerHTML = 'start';
}

function stopAnimation() {
    if (isManualAnimation) {
        destroyManualAnimationTimeout();
    }

    mapInfo.overlay.setPosition(undefined);
    document.getElementById('completestate').innerHTML = 'yes';
    console.log('animation complete');
}

function fitMap(map) {
    var extent = {
        maxLng: Math.max.apply(null, wp.map(function (item) {
            return item[0];
        })),
        minLng: Math.min.apply(null, wp.map(function (item) {
            return item[0];
        })),
        maxLat: Math.max.apply(null, wp.map(function (item) {
            return item[1];
        })),
        minLat: Math.min.apply(null, wp.map(function (item) {
            return item[1];
        }))
    };
    map.getView().fit([extent.minLng, extent.minLat, extent.maxLng, extent.maxLat]);
}

function distanceBetweenPoints(latlng1, latlng2) {
    var line = new ol.geom.LineString([latlng1, latlng2]);
    return line.getLength();
};

function createTextStyle(text) {
    return new ol.style.Text({
        textBaseline: 'middle',
        font: 'Arial',
        text: text,
        fill: new ol.style.Fill({ color: 'blue' }),
        offsetY: 15,
        stroke: new ol.style.Stroke({ color: '#fff', width: 2 })
    });
};

function calculateIntermidiatePoints() {
    var intermidiateWp = [];
    var mapExtent = mapInfo.map.getView().calculateExtent(mapInfo.map.getSize());
    var mapDiagonalDistance = distanceBetweenPoints([mapExtent[0], mapExtent[1]], [mapExtent[2], mapExtent[3]]);

    var dotsPerOnePercentDistance = 1;
    for (var i = 1; i < wp.length; i++) {
        //console.log((distanceBetweenPoints(wp[i - 1], wp[i]) * 100 / mapDiagonalDistance) + ' %', Math.ceil((distanceBetweenPoints(wp[i - 1], wp[i]) * 100 / mapDiagonalDistance)));
        var wpDistToMapDistInPercents = Math.ceil((distanceBetweenPoints(wp[i - 1], wp[i]) * 100 / mapDiagonalDistance));

        // Push actual point
        pushIntermidiateWaypont(intermidiateWp, wp[i - 1], inputData[i - 1]);

        // Push itermidiate points
        var dotsPerCurrentPoints = dotsPerOnePercentDistance * wpDistToMapDistInPercents;
        for (var j = 1; j <= dotsPerCurrentPoints; j++) {
            pushIntermidiateWaypont(intermidiateWp, [
                wp[i - 1][0] + (wp[i][0] - wp[i - 1][0]) * j / (dotsPerCurrentPoints + 1),
                wp[i - 1][1] + (wp[i][1] - wp[i - 1][1]) * j / (dotsPerCurrentPoints + 1)
            ], inputData[i - 1]);
        }

        if (i == wp.length - 1) {
            pushIntermidiateWaypont(intermidiateWp, wp[i], inputData[i]);
        }
    }

    return intermidiateWp;
}

function pushIntermidiateWaypont(intermidiateWp, coordinates, originalWaypointData) {
    intermidiateWp.push(coordinates);
    intermidiateWaypointsToOriginalDataHash[coordinates[0] + coordinates[1]] = originalWaypointData;
}

function createOverlay(map) {
    var overlay = new ol.Overlay({
        element: document.getElementById('overlay'),
        positioning: 'bottom-center'
    });
    map.addOverlay(overlay);
    return overlay;
}

function updateOverlay(overlay, coordinates, text) {
    element: document.getElementById('overlay').innerHTML = text;
    overlay.setPosition(coordinates);
}

function createCarMarker(map) {
    var carMarker = new ol.Feature({
        geometry: new ol.geom.Point(wp[0])
    });

    carMarker.setStyle(new ol.style.Style({
        image: new ol.style.Icon({
            anchor: [0.5, 10],
            anchorXUnits: 'fraction',
            anchorYUnits: 'pixels',
            src: '/Content/img/car.jpg'
        })
    }));

    carMarker.getStyle().setText(createTextStyle(inputData[0].DeviceName));

    map.addLayer(new ol.layer.Vector({
        source: new ol.source.Vector({
            features: [carMarker]
        })
    }));

    return carMarker;
}

function parseWaypoints() {
    var wp = [];
    for (var i = 0; i < inputData.length; i++) {
        wp.push([inputData[i].Lng, inputData[i].Lat]);
    }

    for (var i = 0; i < wp.length; i++) {
        wp[i] = ol.proj.fromLonLat(wp[i]);
    }

    return wp;
}

function createWaypointsLayer(map) {
    var line = new ol.Feature({
        geometry: new ol.geom.LineString(wp)
    });
    line.setStyle(new ol.style.Style({
        stroke: new ol.style.Stroke({ color: '#356AA0', width: 2 })
    }))
    var wpline = new ol.source.Vector({
        features: [line]
    });

    // Add point feature for every coordinate
    for (var i = 0; i < wp.length; i++) {
        var point = new ol.Feature({
            geometry: new ol.geom.Point(wp[i])
        });
        point.setStyle(new ol.style.Style({
            image: new ol.style.Circle({
                radius: 3,
                fill: new ol.style.Fill({ color: '#D01F3C' })
            })
        }));
        wpline.addFeature(point);
    }

    map.addLayer(new ol.layer.Vector({
        source: wpline
    }));
}

function createMapTilesLayer(map) {

    // OSM tiles frequently have errors during load
    //var tileSource = new ol.source.OSM();
    var tileSource = new ol.source.BingMaps({ key: bingMapsKey, imagerySet: 'Road' });

    var tilesState = {
        loaded: 0,
        total: 0
    };
    tileSource.on('tileloadstart', function () {
        tilesState.total++;
    });
    tileSource.on('tileloadend', function (a) {
        tilesState.loaded++;
        if (tilesState.loaded == tilesState.total) {
            console.log('all tiles loaded (' + tilesState.loaded + ')');
            readyToStartAnimation();
        }
    });
    tileSource.on('tileloaderror', function (a, b) {
        console.log('tile load error', a, b);
    });

    map.addLayer(new ol.layer.Tile({
        source: tileSource
    }));
}

function initializeMap() {
    var map = new ol.Map({
        target: document.getElementById('map'),
        loadTilesWhileAnimating: true,
        view: new ol.View({
            center: wp[0],
            zoom: 10,
            minZoom: 2,
            maxZoom: 19
        }),
        controls: []
    });

    createMapTilesLayer(map);
    createWaypointsLayer(map);
    var carMarker = createCarMarker(map);
    fitMap(map);
    var overlay = createOverlay(map);

    return {
        map: map,
        carMarker: carMarker,
        overlay: overlay
    }
}

function destroyManualAnimationTimeout() {
    if (manualAnimationTimeout) {
        clearTimeout(manualAnimationTimeout);
    }
}