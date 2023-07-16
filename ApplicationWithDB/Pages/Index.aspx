<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Header.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ApplicationWithDB.Index" %>

<%@ Register Src="~/Pages/Dynamic.ascx" TagPrefix="PC" TagName="Card" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <PC:Card runat="server" 
        Title="Samsung" Description="something" 
        Image="https://images.unsplash.com/photo-1583573636246-18cb2246697f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1038&q=80">

    </PC:Card>
    <PC:Card runat="server" 
        Title="Samsung" Description="something" 
        Image="https://images.unsplash.com/photo-1583573636246-18cb2246697f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1038&q=80">

    </PC:Card>
</asp:Content>
