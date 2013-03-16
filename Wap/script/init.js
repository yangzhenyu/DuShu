define(function (require, exports, module) {
    var $ = require('lib/jquery.js');
    var resources = require('resources');
   
    exports.run = function () { 
        /**异步加载所需要的模板和样式文件,配置在resources.js中**/
        $.each(resources, function (key, val) {
            require.async(resources[key], function () {
             
                if (typeof (Storage) !== "undefined") {
                   
                    sessionStorage.setItem(key, val);
                }
            });
        });
    }; 
    var scrollcheck = function () {
        $(document).ready(function () {
            var w = $(window).width() - 20;
            if (w > 620) {
                w = 620;
            }
            $(".article img").each(function (i) {
                var image = new Image();
                image.src = $(this).attr("src");
                image.onerror = function () {
                    $(".article img:eq(" + i + ")").attr("src", "/theme/images/noimg2.jpg");
                };

                if ($(".article img:eq(" + i + ")").width() > w) {
                    h = $(".article img:eq(" + i + ")").height() * w / $(".article img:eq(" + i + ")").width()
                    $(".article img:eq(" + i + ")").width(w);
                    $(".article img:eq(" + i + ")").height(h);
                }
            });

            $('#top').click(function () {
                $("html, body").animate({ scrollTop: 0 }, -10);
                return false;
            });
        });
    };

    $(document).bind('scroll', function () {
        scrollcheck();
        if ($(window).scrollTop() <= $(window).height()) {
            $("#top").stop(true, false).animate({ bottom: "-200px" }, 500);
            $("#top").hide();
        } else {
            $("#top").stop(true, false).animate({ bottom: "15px" }, 500);
            $("#top").show();
        }
    });
});