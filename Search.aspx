<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WEBAPP.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* General container styling */
        .container {
            max-width: 960px;
            padding: 20px;
            text-align: center;
            margin: 0 auto; /* Center align the container */
        }

        /* Background and content styling */
        body {
            background-color: #2c2c2c;
            color: #e0e0e0;
            font-family: 'Roboto', sans-serif;
            margin: 0;
            padding: 0;
        }

        h2 {
            font-size: 2.5rem;
            margin-bottom: 20px;
            color: #ffffff;
        }

        p.lead {
            font-size: 1.25rem;
            margin-bottom: 30px;
            color: #b0b0b0;
        }

        /* Form and button styling */
        .input-group {
            max-width: 600px;
            margin: 0 auto; /* Center align the search bar */
            display: flex; /* Make input and button inline */
            align-items: center;
        }

        .form-control {
            border-radius: 50px 0 0 50px;
            padding: 10px 20px;
            font-size: 1rem;
            background-color: #2c2c2c;
            border: 1px solid #444;
            color: #e0e0e0;
            flex: 1; /* Make the input take up available space */
        }

        .btn-primary {
            border-radius: 0 50px 50px 0;
            padding: 10px 20px;
            font-size: 1rem;
            background: #1e88e5;
            border: none;
            color: #ffffff;
            cursor: pointer;
            transition: background 0.3s ease;
        }

        .btn-primary:hover {
            background: #1565c0;
        }

        .form-control::placeholder {
            color: #999;
        }

        /* Card styling */
        .card {
            border-radius: 15px;
            background-color: #1f1f1f;
            box-shadow: 0 3px 15px rgba(0, 0, 0, 0.5);
            margin-bottom: 20px;
            color: #e0e0e0;
        }

        .card-header {
            border-top-left-radius: 15px;
            border-top-right-radius: 15px;
            background-color: #2c2c2c;
            padding: 15px;
            color: #ffffff;
        }

        .card-body {
            padding: 20px;
        }

        .card-title {
            font-size: 1.25rem;
            margin-bottom: 15px;
            color: #ffffff;
        }

        .card-link {
            color: #1e88e5;
        }

        .card-link:hover {
            text-decoration: underline;
        }

        /* Alert for no results */
        .text-danger {
            color: #e53935;
            font-size: 1rem;
        }
        /* Navbar styles */
.navbar {
    padding: 0.5rem 1rem;
}

.navbar .container {
    max-width: 960px; /* Set the max-width to control navbar expansion */
}

.nav-link {
    color: #ffffff;
}

.nav-link:hover {
    color: #e0e0e0;
}

    </style>
    <div class="container mt-5">
        <h2 class="mb-4">Search</h2>
        <p class="lead mb-4">Find hotels, restaurants, and local attractions quickly and easily.</p>

        <!-- Search Form -->
        <div class="input-group mb-4">
            <asp:TextBox ID="SearchTextBox" runat="server" CssClass="form-control" Placeholder="Enter hotel, restaurant, or attraction name" />
            <asp:Button ID="SearchButton" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="SearchButton_Click" />
        </div>
        <asp:Label ID="SearchResultsLabel" runat="server" CssClass="text-danger" />

        <!-- Search Results -->
        <asp:Panel ID="ResultsPanel" runat="server" CssClass="mt-4">
            <!-- This panel will be populated with search results dynamically -->
        </asp:Panel>
    </div>
</asp:Content>
