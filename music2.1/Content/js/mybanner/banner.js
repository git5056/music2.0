//banner
$(document).ready(function () {

    var l =
        [
    {
        "desc": "111111111111111",
        "src": "/content/img/1.jpg",
        "link": "1111111.aspx"
    },
    {
        "desc": "2222222222",
        "src": "/content/img/2.jpg",
        "link": "22222222.aspx"
    },
        {
            "desc": "3333333333",
            "src": "/content/img/3.jpg",
            "link": "333333333.aspx"
        },
    {
        "desc": "4444444",
        "src": "/content/img/4.jpg",
        "link": "4444444.aspx"
    },
    {
        "desc": "555555555",
        "src": "/content/img/5.jpg",
        "link": "55555555.aspx"
    },
    {
        "desc": "666666",
        "src": "/content/img/6.jpg",
        "link": "66666666666.aspx"
    },
    {
        "desc": "7777777777",
        "src": "/content/img/7.jpg",
        "link": "777777777.aspx"
    }
        ];

    var myBanner = function (l,p) {
        var list = l;
        var current_idx=0;
        var $bannel_wraper = $("<div class='bannel_wraper'></div>");
        var $bannel = $("<ul></ul>");
        var $banner_pre = $("<span class='banner_ico banner_pre'></span>");
        var $banner_next = $("<span class='banner_ico banner_next'></span>");
        var $bannel_navigator_wraper = $("<div class='banner_navigator_wraper'></div>");
        var $bannel_navigator = $("<ul class='banner_navigator'></ul>");
        var $bannel_desc_wraper = $("<div class='bot'></div>");

        //防止字体被选中
        $desc_words = $("<p/>")
            .mousedown(function () { return false; })
            .mouseup(function () { return false; });
        //ie
        if (typeof (document.onselectstart) != "undefined") {
            $desc_words.get(0).onselectstart = new Function("return false");
        }
        //fresh
        var fresh = function () {
            $bannel.children("li").css("display", "none");
            $bannel_navigator.children("li").removeClass("active");
            if (list.length != $bannel.children("li").length) {
                alert("出错");
            }
            $bannel.children("li")[current_idx].style = "display:block";
            $bannel_navigator.children("li").eq(current_idx)
                .addClass("active");
            $desc_words.html(list[current_idx].desc);
        }

        //pre.click
        $banner_pre.click(function () {
            current_idx--;
            if (current_idx < 0)
            {
                current_idx = list.length - 1;
            }
            fresh();
        });

        //next.click
        $banner_next.click(function () {

            current_idx++;
            if (current_idx > list.length - 1) {
                current_idx = 0;
            }
            fresh();
        });
        
        var autoJumpHandle = function () {
            current_idx++;
            if (current_idx > list.length - 1) {
                current_idx = 0;
            }
            fresh();
        };

        //autojump
        var autoJump_timer;

        autoJump_timer = setInterval(autoJumpHandle,5 * 1000);

        //default

        
        
        var listLength = list.length;
        for (var i = 0; i < listLength;i++) {
            //ul li
            var $bannerItem = $("<li style='display:none;'></li>").html("<a href='" + list[i].link + "'><img src='" + list[i].src + "' /></a>");
            $bannerItem.appendTo($bannel);

            //regiseter event
            var $bannel_navigator_item=$("<li class='banner_ico'></li>");
            $bannel_navigator_item.mouseover(function () {

                current_idx = $(this).index();
                fresh();
            });
            $bannel_navigator_item.appendTo($bannel_navigator);
        }

        $bannel_desc_wraper.html($desc_words);
        $bannel_navigator_wraper.append($bannel_navigator);
        $bannel.append($banner_pre).append($banner_next).append($bannel_desc_wraper).append($bannel_navigator_wraper);
        $bannel_wraper.append($bannel);

        fresh();
        return $bannel;
    }
    $(".js_banner").append(myBanner(l).addClass("banner"));

    
});

//song_rank_list
$(document).ready(function () {
      m_tabs02 = function (l) {
          var list = l;
          var arr = [];
        var numalgin = function (num) {
            if (num < 1) {
                return "1-100"
            }
            if (num < 10) {
                return "0" + num;
            }
            if (num < 100) {
                return num + "";
            }
            return "1-100";
        }

        var $list_wraper = $("<div class='song_list'></div>");
        var $title = $("<h3></h3>");
        var $tabs = $("<ul class='song_list_tabs'></ul>");
        var $content_wraper = $("<div class='tabs_con'></div>");
        var currenutIdx = 0;

        for (var i = 0; i < list.length; i++) {
            //tabs
            $tabs.append($("<li class=''>" + list[i].btn_name + "</li>"));
            //tabs_content
            var $mod_tabs_item = $("<div class='tabs_item' style='display:none;'></div>");
            var $tabs_item = $("<ul></ul>");
            $mod_tabs_item.append($tabs_item);
            $content_wraper.append($mod_tabs_item);
            for (var j = 0; j < list[i].song_list.length; j++) {
                if (arr[i] == undefined) {
                    arr[i] = new Array();
                }
                arr[i].push(list[i].song_list[j].song_id);
                var $mod_list = $("<div><span class='fl'><span class='num " + (j < 3 ? "blue" : "") + "'> " + numalgin(j + 1) + " </span></span> <span class='fl song_name text_clip'><a href='#'>" + list[i].song_list[j].song_name + "</a></span><span class='fl singer'><a href='/singer/detail/" + list[i].song_list[j].singer_id + "'>" + list[i].song_list[j].singer + "</a></span><span class='fr'><span class='tools'> <a class='play' href='javascript:;' song_id='" + list[i].song_list[j].song_id + "'></a> <a class='down' href='javascript:;' song_id='" + list[i].song_list[j].song_id + "'></a></span></span></div>");
                $tabs_item.append($("<li></li>").html($mod_list).append("<div class='clearfix'></div>"));
                var dd = 2;
            }
            var dd = 2;
        }

        $content_wraper.append($("<div class='m_tools mt10 clearfix'><a class='playlist' href='javascript:;' ></a><a class='music_list_add' href='javascript:;' ></a></div>"));
        $('.playlist', $content_wraper).click(function () {
            var isOpen = false;
            $.ajaxSetup({ async: false });
            $.post('/home/playarr', { 'songids': arr[currenutIdx], 'isloadandplay': true }, function (data) {
                switch (data.code) {
                    case 0:
                        if (data.code1 == 1) {
                            isOpen = false;
                        }
                        else if (data.code1 == 2) {
                            isOpen = true;
                        }
                        else {
                            alert('error');
                        }

                        break;
                    default: break;
                }
            }, 'json');
            if (isOpen) {
                $(this).attr("href", "/home/play").attr('target', 'target');
            }
            else {
                $(this).attr("href", "javascript:;");
            }
        });

        $('.music_list_add', $content_wraper).click(function () {
            var isOpen = false;
            $.ajaxSetup({ async: false });
            $.post('/home/playarr', { 'songids': arr[currenutIdx], 'isloadandplay': false }, function (data) {
                switch (data.code) {
                    case 0:
                        if (data.code1 == 1) {
                            isOpen = false;
                        }
                        else if (data.code1 == 2) {
                            isOpen = true;
                        }
                        else {
                            alert('error');
                        }

                        break;
                    default: break;
                }
            }, 'json');
            if (isOpen) {
                $(this).attr("href", "/home/play").attr('target', 'target');
            }
            else {
                $(this).attr("href", "javascript:;");
            }
        });

        $('.music_list_add', $content_wraper).click(function () {


        });

        $('.tools .play', $content_wraper).click(function () {
            var isOpen = false;
            $.ajaxSetup({ async: false });
            $.post("/home/play", { 'songid': $(this).attr('song_id'), 'isloadandplay': true }, function (data) {
                var dd = 2;
                switch (data.code) {
                    case 0:
                        if (data.code1 == 1) {
                            isOpen = false;
                        }
                        else if (data.code1 == 2) {
                            isOpen = true;
                        }
                        else {
                            alert('error');
                        }

                        break;
                    default: break;
                }
            });
            if (isOpen) {
                $(this).attr("href", "/home/play").attr('target', 'target');
            }
            else {
                $(this).attr("href", "javascript:;");
            }
        });
        var fresh = function () {
            $title.html(list[currenutIdx].title);
            $tabs.children().removeClass("current");
            var asdasd = $tabs.children(":eq(" + currenutIdx + ")");
            $tabs.children(":eq(" + currenutIdx + ")").addClass("current");
            //fresh content
            $content_wraper.children(".tabs_item").css("display", "none");
            $content_wraper.children(":eq(" + currenutIdx + ")").css("display", "block");
        };
        //regiser event
        $tabs.children().mouseover(function () {
            currenutIdx = $(this).index();
            fresh();
            var dd = 2;
        });
        fresh();
        $list_wraper.append($title).append($tabs).append($content_wraper);
        return $list_wraper;
    };

});


//music_tags
$(function () {

    var random=function(min, max) {
        var range = max - min;
        var rand = Math.random();
        return (min + Math.round(rand * range));
    }

    var tags = ["跑步","下午茶" ,"青春校园","旅行" ,"钢琴","咖啡厅","民谣" ,"纯音乐","酒吧" ,"电视剧音乐","R&B", "动漫音乐", "胎教音乐", "搞笑彩铃", "摇滚","甜蜜", "90后", "励志", "KTV", "经典老歌", "情歌对唱", "重金属", "综艺歌曲", "游戏音乐", "80后"];
    var $music_tag = $("<div class='m_tab3 music_tag'><h3 class='title'>音乐标签</h3></div>");
    var $tagsnode = $("<ul class='tags'></ul>");
    for (var i = 0; i < tags.length; i++) {
        var randnum = random(0, 3);
        $tagsnode.append($("<li><a href='/tag/detail?tags=" + tags[i] + "' class=''>" + tags[i].substring(0, 3) + "</a></li>").addClass(
            randnum==0?"green":
            randnum==1?"gray":
            randnum==2?"red":
            randnum==3?"yellow":
            "error"
            ));
    }
    $music_tag.append($tagsnode);
    $(".music_tag_wraper").append($music_tag);
});

//search_box
var g_search_def = "鹿晗";
$(function () {

    $(".search_box input").val(g_search_def);

    $(".search_box span").click(function () {
        var zxczxc = $(this).children("input").val();
        if ($(this).children("input").val() == g_search_def) {
            $(this).children("input").val("");
        }
        $(this).children("input").get(0).focus();       
    });

    $(".search_box input").focusout(function () {
        if ($(this).val() == "") {
            $(this).val(g_search_def);
        }
    });

});