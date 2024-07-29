<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="WEBAPP.Categories" %>

<!DOCTYPE html>
<html lang="en">
<head >
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Smart Travel Assistant</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <h2>Categories</h2>
            <p>Browse through various travel categories to find the best destinations and deals.</p>
        </asp:Content>    
    </form>
</body>
</html>


