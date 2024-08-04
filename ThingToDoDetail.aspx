<%@ Page Title="Thing To Do Details" Language="C#" AutoEventWireup="true" CodeBehind="ThingToDoDetail.aspx.cs" Inherits="WEBAPP.ThingToDoDetail" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Thing To Do Details</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .detail-image {
            width: 100%;
            height: 400px;
            object-fit: cover;
        }
        .detail-container {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container detail-container">
            <h2>Thing To Do Details</h2>
            <div class="row">
                <div class="col-md-6">
                    <asp:Image ID="ThingToDoImage" runat="server" CssClass="detail-image" />
                </div>
                <div class="col-md-6">
                    <h3><asp:Label ID="ThingToDoName" runat="server" CssClass="font-weight-bold" /></h3>
                    <p><asp:Label ID="ThingToDoDescription" runat="server" CssClass="text-muted" /></p>
                    <asp:HyperLink ID="ThingToDoLink" runat="server" CssClass="btn btn-primary">Visit Website</asp:HyperLink>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
