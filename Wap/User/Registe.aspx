<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Registe.aspx.cs" Inherits="Wap.User.Registe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" data-role="content">

        <h1 class="ft20 pagetop">通过手机短信找回密码</h1>
        <article class="pageinfo">本功能仅对绑定手机号码的用户使用! </article>
        <form name="sign-form" id="sign-form">
            <ul>
                <li>
                    <label class="ft20">用户名：</label>
                    <input type="text" name="username" id="Text1" value="" autocorrect="off" autocapitalize="off" /></li>
                <li>
                    <label class="ft20">密码：</label>
                    <input type="password" name="password" id="Password1" value="" /></li>
                <li>
                    <label class="ft20">电子邮箱(用于找回密码)：</label>
                    <input type="password" name="password" id="Password3" value="" /></li>
            </ul>
            <input name="btn_register" type="submit" value="注  册 &raquo;" id="btn_register" data-inline="true" />
            <a style="margin-top: 0.6em; vertical-align: middle; display: inline-block;" href="/?r=space/qqloginformobile" rel="external">
                <img src="http://static2.zhufukc.com/img/Connect_logo_3.png" /></a>
        </form>
        <hr />
        <p class="ft20">我已经有帐号，  <a data-role="button" data-inline="true" data-theme="d" href="login.aspx">登录 &raquo;</a></p>


    </div>

</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">注册账号</span></a> </article>
</asp:Content>

