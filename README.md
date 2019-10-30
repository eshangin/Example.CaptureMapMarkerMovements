# Example.CaptureMapMarkerMovements

This project uses PhantomJS, FFmpeg to capture motion of an object on a map and make video of this motion. OpenLayer used for maps.

## How it works
1. /lib folder contains necessary .exe files
2. phantomjs-capture.js is a script which is used by PhantomJS. It captures images of a map. PureMap MVC view represents a map which is used for image capture. 
3. After phantomjs-capture.js finishes capturing images, the application calls FFMpeg to make a video from the list of previously captured images.
4. Also we have RenderMap view but it is used just for demonstration of vehicle motion. Also you can download video from here
