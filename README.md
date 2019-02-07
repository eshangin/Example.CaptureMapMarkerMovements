# Example.CaptureMapMarkerMovements

This project uses PhantomJS, FFmpeg to capture motion of an object on a map. OpenLayer uses for maps.

## How it works
1. phantomjs-capture.js is a script which is used by PhantomJS. It captures .png images of a map. RenderMap MVC page represents a map. 
2. After phantomjs-capture.js finishes capture images app call FFMpeg to make video from the list of previously captured images.
