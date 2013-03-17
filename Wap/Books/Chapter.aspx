<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Chapter.aspx.cs" Inherits="Wap.Books.Chapter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="ft24 h1_top">目录</h1>
    <article class="new_chapter">
        <a onclick="vipChapter('/t/book/chapter/367195/352/')" href="javascript:;">
            <h2 class="ft24"><span class="c3 new_chapter_m fl">最新章节：</span><span class="c_red4 new_chapter_c fl">第三百五十章 木秀于林 <span class="vip_btn">VIP</span></span><article class="clear"></article>
            </h2>
        </a>
        <p class="ft20 c7 mt_10">更新时间：2013.03.13</p>
        <span class="icon"></span>
    </article>
    <div class="buttons_b">

        <a class="btn btn-success  " type="button"><i class="icon-star"></i>倒序排列</a>
        <a class="btn btn-success  " type="button"><i class="icon-list"></i>正序排列</a>


    </div>
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

