<%@ Page Title="Restaurant Details" Language="C#" AutoEventWireup="true" CodeBehind="RestaurantDetail.aspx.cs" Inherits="WEBAPP.RestaurantDetail" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Restaurant Details</title>
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
            <h2>Restaurant Details</h2>
            <div class="row">
                <div class="col-md-6">
                    <asp:Image ID="RestaurantImage" runat="server" CssClass="detail-image" />
                </div>
            <asp:Image ID="Image1" runat="server" />
            <asp:Label ID="RestaurantName" runat="server" Text="" />
            <asp:Label ID="RestaurantDescription" runat="server" Text="" />
            <asp:HyperLink ID="RestaurantLink" runat="server">Visit Website</asp:HyperLink>
       
            </div>
        </div>
    </form>
</body>
</html>
