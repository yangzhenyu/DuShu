<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="findpwd.aspx.cs" Inherits="Wap.User.findpwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" data-role="content">

        <h1 class="ft20 pagetop">通过邮箱找回密码</h1>
        <article class="pageinfo">本功能仅对绑定邮箱的用户使用! </article>
        <form name="sign-form" id="sign-form">
            <ul>
                <li>
                    <label class="ft20">请输入您的用户名：</label>
                    <input type="text" name="username" id="Text1" value="" autocorrect="off" autocapitalize="off" /></li>
                <li>
                    <label class="ft20">请输入您的电子邮箱：</label>
                    <input type="text" name="password" id="Password3" value="" /></li>
            </ul>
            <input name="btn_register" type="submit" value="确  定 &raquo;" id="btn_register" data-inline="true" />
        <a href="Login.aspx">返回继续登录</a> </form> 

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">找回密码</span></a> </article>
</asp:Content>
