//configure seajs
seajs.config({
    alias: {

        'jquery': 'lib/jquery.js',
        'jqueryMobile': 'lib/jquery.mobile-1.3.0.min'
    },
    preload: [/*'plugin-base','plugin-json',*/'jquery', 'jqueryMobile', (''/*'combineLibs'*/)]
});
define(function (require, exports, module) {
    require('./init').run();
});
