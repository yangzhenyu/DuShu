<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-1.8.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            debugger;
            $("#txt1").text("kdfjkdjfkdjfk");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="txt1" runat="server" />
        </div>
    </form>
</body>
</html>
