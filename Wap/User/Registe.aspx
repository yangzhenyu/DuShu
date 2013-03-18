<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Registe.aspx.cs" Inherits="Wap.User.Registe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" data-role="content">


        <form name="sign-form" id="sign-form">
            <fieldset>
                <legend>
                    <h1 class="ft20 pagetop">欢迎您的光临...</h1>
                </legend>
                <div class="form-content">
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
                    <input name="btn_register" type="submit" value="注  册 &raquo;" id="btn_register"  class="btn btn-primary" />
                    <a style="margin-top: 0.6em; vertical-align: middle; display: inline-block;" href="/?r=space/qqloginformobile" rel="external">
                        <img src="http://static2.zhufukc.com/img/Connect_logo_3.png" /></a>
                </div>
            </fieldset>
        </form>
        <div class="content-foot">
            <hr />
            <p class="ft20">我已经有帐号，  <a class="btn btn-primary" href="login.aspx">登录 &raquo;</a></p>

        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">注册账号</span></a> </article>
</asp:Content>

