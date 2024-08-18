<%@ Page Title="Restaurant Details" Language="C#" AutoEventWireup="true" CodeBehind="RestaurantDetail.aspx.cs" Inherits="WEBAPP.RestaurantDetail" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Restaurant Details</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
<style>
        /* General Body Styling for Dark Mode */
        body {
            background-color: #2c2c2c; /* Dark background color */
            color: #eaeaea; /* Light text color */
            font-family: Arial, sans-serif;
        }

        .container {
            background-color: #1e1e1e; /* Slightly lighter background for container */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.5);
        }

        .detail-container {
            margin-top: 20px;
        }

        .carousel-item img {
            width: 100%;
            height: 400px;
            object-fit: cover;
        }

        .font-weight-bold {
            font-weight: bold;
            color: #f8f9fa; /* Light text color for headers */
        }

        .text-muted {
            color: #b0b0b0; /* Muted text color for descriptions */
        }

        .btn-primary {
            background-color: #007bff;
            border: none;
        }

        .btn-primary:hover {
            background-color: #0056b3;
        }

        /* Additional Information Section Styling */
        .additional-info {
            background-color: #2c2c2c; /* Slightly darker background */
            padding: 15px;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.3);
            margin-top: 20px;
        }

        .additional-info h4 {
            font-size: 1.5rem;
            border-bottom: 2px solid #007bff; /* Blue border under heading */
            padding-bottom: 10px;
            margin-bottom: 15px;
            color: #f8f9fa; /* Light color for heading */
        }

        .additional-info ul {
            list-style-type: none; /* Remove bullet points */
            padding: 0;
            margin: 0;
        }

        .additional-info li {
            margin-bottom: 10px; /* Spacing between list items */
            font-size: 1rem;
            color: #eaeaea; /* Light color for list items */
            background-color: #343a40; /* Slightly darker background for list items */
            padding: 10px;
            border-radius: 4px;
            box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.1);
        }

        .additional-info li span {
            font-weight: bold;
            color: #007bff; /* Highlight key parts with blue color */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container detail-container">
            <h2>Restaurant Details</h2>
            <div class="row">
                <div class="col-md-6">
                    <asp:PlaceHolder ID="RestaurantImagesPlaceHolder" runat="server"></asp:PlaceHolder>
                </div>
                <div class="col-md-6">
                    <h3><asp:Label ID="RestaurantName" runat="server" CssClass="font-weight-bold" /></h3>
                    <p><asp:Label ID="RestaurantDescription" runat="server" CssClass="text-muted" /></p>
                    <asp:HyperLink ID="RestaurantLink" runat="server" CssClass="btn btn-primary" Text="Visit Website" />
                    <div>
                        <!-- Additional content for the restaurant -->
                        <h4>Additional Information</h4>
                        <ul>
                            <li>Address: <asp:Label ID="RestaurantAddress" runat="server" /></li>
                            <li>Contact: <asp:Label ID="RestaurantContact" runat="server" /></li>
                            <li>Cuisine: <asp:Label ID="RestaurantCuisine" runat="server" /></li>
                            <li>Hours: <asp:Label ID="RestaurantHours" runat="server" /></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Include jQuery, Popper.js, and Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
