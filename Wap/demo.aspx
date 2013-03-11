﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="Wap.demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta name="viewport" id="viewport" content="width=device-width, initial-scale=1">
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="apple-touch-fullscreen" content="YES">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <script src="Js/jquery.js"></script>
    <script src="Js/jquery.mobile-1.3.0.js"></script>
    <link href="Css/common.css" rel="stylesheet" />
    <link href="Css/jquery.mobile-1.3.0.min.css" rel="stylesheet" />
    <link href="Css/jquery.mobile.structure-1.3.0.min.css" rel="stylesheet" />
    <link href="Css/jquery.mobile.theme-1.3.0.min.css" rel="stylesheet" />
    <link href="Css/index.css" rel="stylesheet" />
    <script src="Js/index.js"></script>
</head>
<body>
    <div data-role="page" id="index">
        <header>
            <div class="top">
                <div class="logo">
                    <a href="/?r=mobile/index">
                        <img width="150" src="http://static2.zhufukc.com/img/base/logo-small.png?1" /></a>
                </div>
                <div class="uinfo">
                    <a href="/?r=mobile/login" class="action">登录</a> <a href="/?r=mobile/reg" class="action">注册</a>
                </div>
            </div>
            <div data-role="header">
                <div data-role="navbar">
                    <ul>
                        <li><a href="/?r=mobile/recipes"   class="headmenu">首页</a></li>
                        <li><a href="/?r=mobile/cookbooks" class="headmenu">下载</a></li>
                        <li><a href="/?r=mobile/newslist"  class="headmenu">书库</a></li>
                        <li><a href="/?r=mobile/newslist"  class="headmenu">排行</a></li>
                    </ul>
                </div>
            </div>
        </header>
        <div id="searchform" style="padding: 5px 0; display: block;">
            <form action="/?r=mobile/search" method="get">
                <input type="hidden" name="type" value="1" />
                <div class="ui-input-search ui-shadow-inset ui-btn-corner-all ui-btn-shadow ui-icon-searchfield ui-body-c">
                    <input type="search" data-role="none" name="key" id="search" placeholder="搜索书本或者作者名字" class="ui-input-text ui-body-c" />
                </div>
            </form>
            <article>
                <a href="#" class="rc1 ft22 ml_25">重生</a>
                <a href="#" class="rc2 ft22 ml_25">美女</a>
                <a href="#" class="rc3 ft22 ml_25">重生</a>
                <a href="#" class="rc4 ft22 ml_25">美女</a>
                <a href="#" class="rc5 ft22 ml_25">重生</a>
                <a href="#" class="rc6 ft22 ml_25">美女</a>
            </article>
        </div>
        <div class="tu_slide">
            <div class="content">
                <ul class="img">
                    <li><a href="/?r=mobile/RecipeDetails&recipeid=17598">
                        <img src="http://img.zhufukc.com/images/other/20130105/21ed0a71817e23a980180e92f69acc12.jpg" class="slideimg" width="310" height="176" /></a></li>
                    <li><a href="/?r=mobile/RecipeDetails&recipeid=16865">
                        <img src="http://img.zhufukc.com/images/other/20121015/2cf616051f0778d9761b6802e9a2a6e1.jpg" class="slideimg" width="310" height="176" /></a></li>
                    <li><a href="/?r=mobile/RecipeDetails&recipeid=9521">
                        <img src="http://img.zhufukc.com/images/blank.gif" _src="http://img.zhufukc.com/images/other/20120917/fe26d895721d161cc8c0759ce90c6e3c.jpg" class="slideimg" width="310" height="176" /></a></li>
                    <li><a href="/?r=mobile/RecipeDetails&recipeid=13836">
                        <img src="http://img.zhufukc.com/images/blank.gif" _src="http://img.zhufukc.com/images/other/20120819/a3843da5892605d0eaef72ee938e960b.jpg" class="slideimg" width="310" height="176" /></a></li>
                </ul>
                <div class="action">
                    <div class="prev pg-btn"><a>上一页</a></div>
                    <div class="trigs">
                        <ul>
                            <li class="cur">1</li>
                            <li class="">2</li>
                            <li class="">3</li>
                            <li class="">4</li>
                        </ul>
                    </div>
                    <div class="next pg-btn"><a>下一页</a></div>
                </div>
            </div>
        </div>
        <div class="blockContainer">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">畅销榜 </article>
                    <article class="fr mark">
                        <a href="javascript:;" class="c_gray current">周榜</a>
                        <a href="javascript:;" class="ml_25 c_gray ">月榜</a>
                        <a href="javascript:;" class="c_gray ml_25">总榜</a>
                        <article class="mark_line line2"></article>
                    </article>
                </article>
            </nav>

            <div class="touchblock ani">
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351253/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/365656/"><span class="num num_c ft18 fl">4</span><span class="fl title">护花狂龙<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351589/"><span class="num num_c ft18 fl">5</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    
                </section>
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351253/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/365656/"><span class="num num_c ft18 fl">4</span><span class="fl title">护花狂龙<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351589/"><span class="num num_c ft18 fl">5</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    <article class="more">
                        <a href="/t/rank/all/sale/month/">
                            <button class="more_btn ft24 c3">更多 </button>
                        </a>
                    </article>
                </section>
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351193/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351253/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349017/"><span class="num num_c ft18 fl">4</span><span class="fl title">药鼎仙途<span class="title_b">(寒香寂寞)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351510/"><span class="num num_c ft18 fl">5</span><span class="fl title">特种兵痞在校园<span class="title_b">(艾连)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    <article class="more">
                        <a href="/t/rank/all/sale/total/">
                            <button class="more_btn ft24 c3">更多 </button>
                        </a>
                    </article>
                </section>
            </div>
        </div>
        <nav class="p4 mt_25">
            <article class="menu ft24">
                <article class="fl title c_gray">热门标签 </article>
            </article>
        </nav>
        <section class="p7 p7_20">
            <a href="/t/book/search/?query=%E7%A9%BF%E8%B6%8A" class="k1">穿越</a>
            <a href="/t/book/search/?query=%E9%87%8D%E7%94%9F" class="k2">重生</a>
            <a href="/t/book/search/?query=%E6%80%BB%E8%A3%81" class="k3">总裁</a>
            <a href="/t/book/search/?query=%E7%BE%8E%E5%A5%B3" class="k4">美女</a>
            <a href="/t/book/search/?query=%E6%90%9E%E7%AC%91" class="k5">搞笑</a>
            <a href="/t/book/search/?query=%E4%BF%AE%E7%9C%9F" class="k6">修真</a>
            <a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k7">极品</a>
            <a href="/t/book/search/?query=%E7%83%AD%E8%A1%80" class="k8">热血</a>
            <a href="/t/book/search/?query=%E8%99%90%E5%BF%83" class="k9">虐心</a>
            <a href="/t/book/search/?query=%E5%A5%87%E5%B9%BB" class="k10">奇幻</a>
            <a href="/t/book/search/?query=%E5%86%9B%E4%BA%8B" class="k11">军事</a>
            <a href="/t/book/search/?query=%E8%B1%AA%E9%97%A8" class="k12">豪门</a>
            <a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k13">极品</a>
            <a href="/t/book/search/?query=%E6%9A%A7%E6%98%A7" class="k15">暧昧</a>
            <a href="/t/book/search/?query=%E5%8D%87%E7%BA%A7" class="k16">升级</a>

        </section>

        <div data-role="footer">
            <section class="p9">

                <nav class="wap">请在wifi或3G下浏览(<a href="http://wap.tadu.com" alt="wap.tadu.com">点此访问简版</a>) </nav>
                <nav>
                    <ul>
                        <li><a href="/t/index/">首页</a><span class="line dot"></span> </li>
                        <li><a href="/t/copyright/">声明</a><span class="line"></span> </li>
                        <li><a href="/t/feedback/">建议</a><span class="line"></span> </li>
                        <li><a href="/t/service/">客服</a><span class="line"></span> </li>
                        <li><a href="/t/help/">帮助</a> </li>
                    </ul>
                </nav>
                <div>
                    <p>塔读tadu.com&nbsp;<span id="time"></span> </p>
                    <p>京ICP备09017823号 </p>
                </div>
            </section>
        </div>
    </div>
</body>
</html>
