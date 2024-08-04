<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="WEBAPP.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .category-section {
            margin-bottom: 40px;
        }
        .card {
            display: flex;
            flex-direction: column;
            border: none;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
        }
        .card-img-top {
            width: 100%;
            height: 200px;
            object-fit: cover;
        }
        .card-body {
            flex: 1 1 auto;
            padding: 15px;
        }
        .card-title {
            font-size: 1.25rem;
            margin-bottom: 10px;
        }
        .card-text {
            font-size: 1rem;
            color: #555;
        }
        .btn-primary {
            background-color: #007bff;
            border: none;
            padding: 10px 20px;
        }
        .card-wrapper {
            margin-bottom: 20px;
        }
        /* site.css */

/* General body styling */
body {
    background-color: #2c2c2c;
    color: #eaeaea;
    font-family: Arial, sans-serif;
}

/* Card styling */
.card {
    background-color: #343a40;
    color: #f8f9fa;
    border: 1px solid #495057;
    transition: all 0.3s ease;
}

.card:hover {
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.4);
}

.card-img-top {
    height: 200px;
    object-fit: cover;
}

.card-body {
    padding: 15px;
}

.card-title {
    font-size: 1.25rem;
    margin-bottom: 10px;
}

.card-text {
    font-size: 1rem;
    color: #eaeaea;
}

.btn-primary {
    background-color: #007bff;
    border: none;
    padding: 10px 20px;
}

.btn-primary:hover {
    background-color: #0056b3;
    border-color: #004085;
}

/* Category section styling */
.category-section {
    margin-bottom: 40px;
}

.card-wrapper {
    margin-bottom: 20px;
}

    </style>
    <div class="container">
        <h2>Categories</h2>
        <p>Browse through various travel categories to find the best destinations and deals.</p>

        <!-- Hotels Section -->
        <div class="category-section">
            <h3>Hotels</h3>
            <div class="row">
                <asp:Repeater ID="HotelsRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 card-wrapper">
                            <div class="card mb-4">
                                <img src='<%# Eval("ImageUrl") %>' class="card-img-top" alt="Hotel Image">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                    <p class="card-text"><%# Eval("Description") %></p>
                                    <a href='<%# Eval("Link") %>' class="btn btn-primary">View Details</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

        <!-- Restaurants Section -->
        <div class="category-section">
            <h3>Restaurants</h3>
            <div class="row">
                <asp:Repeater ID="RestaurantsRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 card-wrapper">
                            <div class="card mb-4">
                                <img src='<%# Eval("ImageUrl") %>' class="card-img-top" alt="Restaurant Image">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                    <p class="card-text"><%# Eval("Description") %></p>
                                    <a href='<%# Eval("Link") %>' class="btn btn-primary">View Details</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

        <!-- Things To Do Section -->
        <div class="category-section">
            <h3>Things To Do</h3>
            <div class="row">
                <asp:Repeater ID="ThingsToDoRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 card-wrapper">
                            <div class="card mb-4">
                                <img src='<%# Eval("ImageUrl") %>' class="card-img-top" alt="Activity Image">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name") %></h5>
                                    <p class="card-text"><%# Eval("Description") %></p>
                                    <a href='<%# Eval("Link") %>' class="btn btn-primary">View Details</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
