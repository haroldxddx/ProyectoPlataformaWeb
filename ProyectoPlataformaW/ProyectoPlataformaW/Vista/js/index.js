// For Local module default:
ZoomMtg.setZoomJSLib('node_modules/@zoomus/websdk/dist/lib', '/av');
// For CDN version default
ZoomMtg.setZoomJSLib('https://dmogdx0jrul3u.cloudfront.net/1.7.9/lib', '/av');
// For Global use source.zoom.us:
ZoomMtg.setZoomJSLib('https://source.zoom.us/1.7.9/lib', '/av');
// In China use jssdk.zoomus.cn:
ZoomMtg.setZoomJSLib('https://jssdk.zoomus.cn/1.7.9/lib', '/av'); 



ZoomMtg.preLoadWasm();
ZoomMtg.prepareJssdk();

