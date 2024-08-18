<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBAPP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Custom shadow effect for cards */
.shadow-custom {
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.shadow-custom:hover {
    transform: translateY(-10px);
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
}

/* Style for card icons */
.card-icon {
    font-size: 3rem;
    color: rgba(0, 0, 0, 0.1);
    position: absolute;
    bottom: 15px;
    right: 15px;
}

.card-body {
    position: relative;
    padding: 2rem;
}
/* Background color for the entire page */
body {
    background-color: #2c2c2c; /* Dark background for the page */
    color: #eaeaea; /* Light text color for better readability */
}

/* Custom shadow effect for cards */
.shadow-custom {
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.shadow-custom:hover {
    transform: translateY(-10px);
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.4);
}

/* Style for card icons */
.card-icon {
    font-size: 3rem;
    color: rgba(0, 0, 0, 0.1);
    position: absolute;
    bottom: 15px;
    right: 15px;
}

.card-body {
    position: relative;
    padding: 2rem;
}

/* Card background and text color */
.card {
    background-color: #343a40; /* Dark background for the cards */
    color: #f8f9fa; /* Light text color for cards */
}
    </style>
    <main class="container mt-5">
        <section class="text-center mb-5">
            <h1 class="display-4">Smart Travel Assistant Dashboard</h1>
            <p class="lead">Your personalized travel planning starts here</p>
        </section>

        <div class="row text-center">
            <!-- Search Card -->
            <div class="col-md-6 col-lg-4 mb-4">
                <div class="card h-100 border-primary shadow-custom bg-dark text-light">
                    <div class="card-body">
                        <h2 class="card-title text-primary">Search</h2>
                        <p class="card-text">Find flights, hotels, and local attractions quickly and easily.</p>
                        <a class="btn btn-primary" href="Search.aspx">Search Now &raquo;</a>
                        <i class="bi bi-search card-icon"></i>
                    </div>
                </div>
            </div>

            <!-- Categories Card -->
            <div class="col-md-6 col-lg-4 mb-4">
                <div class="card h-100 border-success shadow-custom bg-dark text-light">
                    <div class="card-body">
                        <h2 class="card-title text-success">Categories</h2>
                        <p class="card-text">Browse through various travel categories to find the best destinations and deals.</p>
                        <a class="btn btn-success" href="Categories.aspx">Explore Categories &raquo;</a>
                        <i class="bi bi-tags card-icon"></i>
                    </div>
                </div>
            </div>

            <!-- About Us Card -->
            <div class="col-md-6 col-lg-4 mb-4">
                <div class="card h-100 border-info shadow-custom bg-dark text-light">
                    <div class="card-body">
                        <h2 class="card-title text-info">About Us</h2>
                        <p class="card-text">Learn more about our mission to simplify travel planning.</p>
                        <a class="btn btn-info" href="About.aspx">About Us &raquo;</a>
                        <i class="bi bi-info-circle card-icon"></i>
                    </div>
                </div>
            </div>

            <!-- Contact Card -->
            <div class="col-md-6 col-lg-4 mb-4">
                <div class="card h-100 border-danger shadow-custom bg-dark text-light">
                    <div class="card-body">
                        <h2 class="card-title text-danger">Contact</h2>
                        <p class="card-text">Have questions? Get in touch with us for support and inquiries.</p>
                        <a class="btn btn-danger" href="Contact.aspx">Contact Us &raquo;</a>
                        <i class="bi bi-envelope card-icon"></i>
                    </div>
                </div>
            </div>

            <!-- Profile Card -->
            <div class="col-md-6 col-lg-4 mb-4">
                <div class="card h-100 border-warning shadow-custom bg-dark text-light">
                    <div class="card-body">
                        <h2 class="card-title text-warning">Your Profile</h2>
                        <p class="card-text">View and manage your profile information and travel preferences.</p>
                        <a class="btn btn-warning" href="Profile.aspx">My Profile &raquo;</a>
                        <i class="bi bi-person card-icon"></i>
                    </div>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
