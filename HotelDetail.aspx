<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelDetail.aspx.cs" Inherits="WEBAPP.HotelDetail" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Details</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .detail-container {
            margin-top: 20px;
        }
        .carousel-item img {
            width: 100%;
            height: 400px;
            object-fit: cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container detail-container">
            <h2>Hotel Details</h2>
            <div class="row">
                <div class="col-md-6">
                    <asp:PlaceHolder ID="HotelImagesPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
                <div class="col-md-6">
                    <h3><asp:Label ID="HotelName" runat="server" CssClass="font-weight-bold" /></h3>
                    <p><asp:Label ID="HotelDescription" runat="server" CssClass="text-muted" /></p>
                    <asp:HyperLink ID="HotelLink" runat="server" CssClass="btn btn-primary" Text="Visit Website" />
                    <div>
                        <!-- Additional content for the hotel -->
                        <h4>Additional Information</h4>
                        <ul>
                            <li>Amenities: <asp:Label ID="HotelAmenities" runat="server" /></li>
                            <li>Location: <asp:Label ID="HotelLocation" runat="server" /></li>
                            <li>Contact: <asp:Label ID="HotelContact" runat="server" /></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
