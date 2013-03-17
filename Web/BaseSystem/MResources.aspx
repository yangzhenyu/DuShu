<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage.Master" AutoEventWireup="true" CodeFile="MResources.aspx.cs" Inherits="BaseSystem_MResources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        $(function () {
            doQuery();
            $("#add").click(function () {
                $.AddAction(600, 280, "添加资源", "AResources.aspx", doQuery);
            });
            $("#edit").click(function () {
                $.EditAction(600, 280, "编辑资源", "EResources.aspx", doQuery);
            });
            $("#delete").click(function () {
                $.DeleteAction("", doQuery);
            });
        });
        function doQuery() {
            $("#btnQuery").click();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <div class="btn-group">
            <a class="btn" id="add"><i class="icon-plus-sign"></i>新增</a>
            <a class="btn" id="edit"><i class="icon-edit"></i>修改</a>
            <a class="btn" id="delete"><i class="icon-remove"></i>删除</a>
        </div>
        <div class="cont_tools">
            <div class="input-prepend">
                <span class="add-on"><i class="icon-envelope"></i>资源名称</span>
                <input id="prependedInput" size="16" style="width: 100px"
                    type="text" />
                <asp:Button ID="btnQuery" CssClass="btn btn-primary" Text="查询" runat="server" />
            </div>
        </div>
        <table cellspacing="1" cellpadding="1" width="100%" border="0">
            <tr height="25">
                <td align="center">用户帐号</td>
                <td align="center">真实姓名</td>
                <td align="center">性别</td>
                <td align="center">联系方式</td>
                <td align="center">电子邮箱</td>
                <td align="center">联系地址</td>
                <td align="center">邮编</td>
                <td align="center">备注</td>
                <td align="center">删除</td>
            </tr>
            <asp:Repeater ID="MyRepeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "UserName")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "TrueName")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Sexy")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Telephone")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Email")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Address")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Postcode")%>
                        </td>
                        <td align="center">
                            <%# DataBinder.Eval(Container.DataItem, "Description").ToString().Length > 10 ? DataBinder.Eval(Container.DataItem, "Description").ToString().Substring(0, 7) + "..." : DataBinder.Eval(Container.DataItem, "Description")%>
                        </td>
                        <td align="center"></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr bgcolor="#E0E0E0">
                <td colspan="9"></td>
            </tr>
        </table>
    </form>
</asp:Content>

