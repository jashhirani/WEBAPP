<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WEBAPP.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style>
        /* site.css */

/* General container styling */
.container {
    max-width: 960px;
}

/* Form and button styling */
.input-group {
    width: 100%;
}

.input-group-append {
    margin-left: -1px;
}

.form-control {
    border-radius: 0;
}

.btn-primary {
    border-radius: 0;
}

/* Search results card styling */
.card {
    border: 1px solid #ddd;
    border-radius: 0.25rem;
    margin-bottom: 1rem;
}

.card-header {
    background-color: #f8f9fa;
    border-bottom: 1px solid #ddd;
}

.card-body {
    padding: 1rem;
}

.card-title {
    margin-bottom: 0.75rem;
}

.card-link {
    color: #007bff;
}

.card-link:hover {
    text-decoration: underline;
}

/* Alert for no results */
.text-danger {
    color: #dc3545;
}

    </style>
    <div class="container mt-5">
        <h2 class="mb-4">Search</h2>
        <p class="lead mb-4">Find hotels, restaurants, and local attractions quickly and easily.</p>

        <!-- Search Form -->
        <div class="row justify-content-center">
            <div class="col-md-8">
                <div class="input-group mb-4">
                    <asp:TextBox ID="SearchTextBox" runat="server" CssClass="form-control" Placeholder="Enter hotel, restaurant, or attraction name" />
                    <div class="input-group-append">
                        <asp:Button ID="SearchButton" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="SearchButton_Click" />
                    </div>
                </div>
                <asp:Label ID="SearchResultsLabel" runat="server" CssClass="text-danger" />
            </div>
        </div>

        <!-- Search Results -->
        <asp:Panel ID="ResultsPanel" runat="server" CssClass="mt-4">
            <!-- This panel will be populated with search results dynamically -->
        </asp:Panel>
    </div>
</asp:Content>
