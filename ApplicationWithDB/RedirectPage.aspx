﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectPage.aspx.cs" Inherits="ApplicationWithDB.RedirectPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="LoginRedirect" runat="server" Text="Welcome"></asp:Label>
        </div>

        <div>
            <asp:Button ID="Logout" runat="server"  Text="log out" OnClick="Logout_Click" />
        </div>
    </form>
</body>
</html>
