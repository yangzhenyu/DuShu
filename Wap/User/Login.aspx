<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Wap.User.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div id="content" data-role="content">

        <h3>欢迎您的光临...</h3>

        <form id="sign-form" name="sign-form" method="post" action="http://m.triviala.com/signin">
            <ul>
                <li>
                    <label>用户名或注册邮箱</label>
                    <input type="text" name="username" id="username" value="" autocorrect="off" autocapitalize="off" /></li>
                <li>
                    <label>密码</label>
                    <input type="password" name="password" id="" value="" /></li>
            </ul>
            <input id="btnSign" name="btnSign" data-inline="true" type="submit" value="登  录 &raquo;" />
            <a href="findpwd.aspx">忘记密码？</a>
        </form>
        <div class="sep"></div>
        <div id="sign-register">
            <h3>还没有账号? 快速免费注册！</h3>
            <p>保存你的阅读记录，阅读更快更新更多！</p>
            <a data-role="button" data-inline="true" data-theme="d" href="Registe.aspx">点击注册 &raquo;</a>
        </div>

    </div>


</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">登录</span></a> </article>
</asp:Content>

