<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ApplicationWithDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<form id="form1" runat="server">
    <div class="container mt-5">
  <div class="mb-3">
    <label for="idInput" class="form-label">ID</label>
    <input type="text" class="form-control" id="idInput" runat="server" name="idInput"/>
  </div>
  <div class="mb-3">
    <label for="nameInput" class="form-label">Name</label>
    <input type="text" class="form-control" runat="server" id="nameInput" name="nameInput"/>
  </div>
  <asp:button type="submit" runat="server" class="btn btn-primary" onclick="SubmitButton_Click"></asp:button>
        </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
</form>


</body>
</html>
