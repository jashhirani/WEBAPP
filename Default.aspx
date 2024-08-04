<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBAPP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="container mt-5">
        <section class="text-center mb-5">
            <h1 class="display-4">Smart Travel Assistant Dashboard</h1>
            <p class="lead">Your personalized travel planning starts here.</p>
        </section>

        <div class="row text-center">
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body">
                        <h2 class="card-title">Search</h2>
                        <p class="card-text">Find flights, hotels, and local attractions quickly and easily.</p>
                        <a class="btn btn-primary" href="Search.aspx">Search Now &raquo;</a>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body">
                        <h2 class="card-title">Categories</h2>
                        <p class="card-text">Browse through various travel categories to find the best destinations and deals.</p>
                        <a class="btn btn-primary" href="Categories.aspx">Explore Categories &raquo;</a>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body">
                        <h2 class="card-title">About Us</h2>
                        <p class="card-text">Learn more about our mission to simplify travel planning.</p>
                        <a class="btn btn-primary" href="About.aspx">About Us &raquo;</a>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body">
                        <h2 class="card-title">Contact</h2>
                        <p class="card-text">Have questions? Get in touch with us for support and inquiries.</p>
                        <a class="btn btn-primary" href="Contact.aspx">Contact Us &raquo;</a>
                    </div>
                </div>
            </div>
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body">
                        <h2 class="card-title">Your Profile</h2>
                        <p class="card-text">View and manage your profile information and travel preferences.</p>
                        <a class="btn btn-primary" href="Profile.aspx">My Profile &raquo;</a>
                    </div>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
