<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBAPP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="dashboardTitle">
            <h1 id="dashboardTitle">Smart Travel Assistant Dashboard</h1>
            <p class="lead">Your personalized travel planning starts here.</p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="searchTitle">
                <h2 id="searchTitle">Search</h2>
                <p>
                    Find flights, hotels, and local attractions quickly and easily.
                </p>
                <p>
                    <a class="btn btn-primary" href="Search.aspx">Search Now &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="categoryTitle">
                <h2 id="categoryTitle">Categories</h2>
                <p>
                    Browse through various travel categories to find the best destinations and deals.
                </p>
                <p>
                    <a class="btn btn-primary" href="Categories.aspx">Explore Categories &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="recommendationTitle">
                <h2 id="recommendationTitle">Recommendations</h2>
                <p>
                    Get personalized recommendations based on your travel history and preferences.
                </p>
                <p>
                    <a class="btn btn-primary" href="Recommendations.aspx">View Recommendations &raquo;</a>
                </p>
            </section>
        </div>

        <div class="row">
            <section class="col-md-4" aria-labelledby="aboutTitle">
                <h2 id="aboutTitle">About Us</h2>
                <p>
                    Learn more about our mission to simplify travel planning.
                </p>
                <p>
                    <a class="btn btn-primary" href="About.aspx">About Us &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="contactTitle">
                <h2 id="contactTitle">Contact</h2>
                <p>
                    Have questions? Get in touch with us for support and inquiries.
                </p>
                <p>
                    <a class="btn btn-primary" href="Contact.aspx">Contact Us &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="profileTitle">
                <h2 id="profileTitle">Your Profile</h2>
                <p>
                    View and manage your profile information and travel preferences.
                </p>
                <p>
                    <a class="btn btn-primary" href="Profile.aspx">My Profile &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
