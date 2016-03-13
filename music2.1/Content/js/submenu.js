$(function () {
    $(".nav li").each(function () {
        $(this).mouseover(function () {
            $(this).children("a").addClass("mouseover");
            switch ($(this).children("a:eq(0)").html()) {
                case "乐库":
                case "视频":
                    if($(this).children(".submenu"))
                    {
                        $(this).children(".submenu").css("display", "block");
                    }
                    break;
                default: break;
            }
            
        });

        $(this).mouseleave(function () {
            $(this).children("a").removeClass("mouseover")
            switch ($(this).children("a:eq(0)").html()) {
                case "乐库":
                case "视频":
                    if ($(this).children(".submenu")) {
                        $(this).children(".submenu").css("display", "none");
                    }
                    break;
                    //默认
                default:  break;
            }

        });

    });
    $(".submenu dd").each(function () {
        $(this).mouseover(function () {
            //$(this).parent("li").children("a").removeClass("mouseover");
            $(this).css("color", "blue");
        });
    });

    $(".submenu dd").mouseleave(function () {
        $(this).css("color", "#6A6B6C");
    });

    $(".submenu").mouseleave(function () {
        $(this).parent("li").children("a").removeClass("mouseover");
        $(this).css("display", "none");
    });
});