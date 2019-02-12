# Example.CaptureMapMarkerMovements

This project uses PhantomJS, FFmpeg to capture motion of an object on a map. OpenLayer used for maps.

## How it works
1. phantomjs-capture.js is a script which is used by PhantomJS. It captures images of a map. RenderMap MVC page represents a map. 
2. After phantomjs-capture.js finishes capturing images, the application calls FFMpeg to make a video from the list of previously captured images.
