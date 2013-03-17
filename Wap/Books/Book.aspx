<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="Wap.Books.Book" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/book.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <section class="book_t_bg span6">
            <section class="book relative">
                <div class="fl">
                    <img src="http://media.tadu.com/a/0/3/a/a03a1f623be44656934be97cf7246b69_a.jpg">
                </div>
                <div class="fl">
                    <div class="shadow"></div>
                </div>
                <div class="fl ml_20 book_info ft22 c7">
                    <p>作者: 米橙子</p>
                    <p>点击: 4055937</p>
                    <p>字数: 102万字</p>
                    <p>状态: 连载中</p>
                </div>
                <section class="p27_1 ft22 award_top_msg"></section>
                <div class="clear"></div>
            </section>
            <div class="buttons_b">
                <div class="buttons">
                    <a class="btn btn-info " type="button"><i class="icon-book"></i>阅读</a>
                    <a class="btn btn-success  " type="button"><i class="icon-star"></i>收藏</a>
                    <a class="btn btn-success  " type="button"><i class="icon-list"></i>目录</a>
                    <a class="btn   btn-info " type="button"><i class="icon-bookmark"></i>加入书单</a>

                </div>
            </div>
        </section>
        <section class="book_intr span6">


            <section class="book_con c3 ft22">
                <h2 class="ft22">书籍简介：</h2>
                <article class="ft22">
                    <p>妹妹任性私奔，姐姐易嫁入宫 ； 毒霸后宫的竟然是自己的亲姑姑，姑侄争宠，明争暗斗，冷不防身边生死之交的好姐妹竟然一把把快刀暗中扎来。 曾经的初恋挚爱，竟然进宫当了太监。 腹黑的皇上，笑里藏刀的皇后，步步惊心。 惊涛骇浪宫斗谋生，▲ </p>
                </article>
            </section>
        </section>
    </div>
    <article class="new_chapter">
        <a onclick="vipChapter('/t/book/chapter/367195/352/')" href="javascript:;">
            <h2 class="ft24"><span class="c3 new_chapter_m fl">最新章节：</span><span class="c_red4 new_chapter_c fl">第三百五十章 木秀于林 <span class="vip_btn">VIP</span></span><article class="clear"></article>
            </h2>
        </a>
        <p class="ft20 c7 mt_10">更新时间：2013.03.13</p>
        <span class="icon"></span>
    </article>
    <nav class="p4">
        <div class="  menu">
            <div class="bookIndex white" id="list">
                <span id="list1">目录</span><span id="img"><img onclick="new_page('1','3092384','desc')" src="http://r8.11222.cn/booktouch/img/con_down.png"></span><div class="white">▲</div>
            </div>
            <div class="bookComment gray">
                评论<div class="white" style="display: none;">▲</div>
            </div>
            <div class="bookView gray">
                书单<div class="white" style="display: none;">▲</div>
            </div>
        </div>
    </nav>
    <section class="p25 ft24 c3">
        <ul>
            <li class="li_t"><a href="/t/book/chapter/367195/1/"><span class="icon"></span><span class="va title">第一章 百啭无人能解</span><article class="clear"></article>
            </a></li>
            <li><a href="/t/book/chapter/367195/2/"><span class="icon"></span><span class="va title">第二章 等闲变作故人心</span><article class="clear"></article>
            </a></li>
            <li><a href="/t/book/chapter/367195/3/"><span class="icon"></span><span class="va title">第三章 君恩难测</span><article class="clear"></article>
            </a></li>
        </ul>
    </section>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">{书本名称}</span></a> </article>

</asp:Content>

