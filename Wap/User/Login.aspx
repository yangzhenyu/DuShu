<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Wap.User.Login" %>

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
                            <label>用户名或注册邮箱</label>
                            <input type="text" name="username" id="Text1" value="" autocorrect="off" autocapitalize="off" /></li>
                        <li>
                            <label>密码</label>
                            <input type="password" name="password" id="Password1" value="" /></li>
                    </ul>
                    <input name="btnSign" data-inline="true" type="submit" value="登  录 &raquo;" class="btn btn-primary" />
                    <a href="findpwd.aspx">忘记密码？</a>
                </div>
            </fieldset>
        </form>
        <div class="content-foot">
            <div class="sep"></div>
            <div id="sign-register">
                <h3>还没有账号? 快速免费注册！</h3>
                <p>保存你的阅读记录，阅读更快更新更多！</p>
                <a data-role="button" data-inline="true" data-theme="d" href="Registe.aspx">点击注册 &raquo;</a>
            </div>
        </div>
    </div>



</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">登录</span></a> </article>
</asp:Content>

