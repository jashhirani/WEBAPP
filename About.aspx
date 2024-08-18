<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WEBAPP.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* General Styling */
        body {
            background-color: #2c2c2c;
            color: #e0e0e0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        
        main {
            padding: 20px;
            margin: 0 auto;
            max-width: 800px;
        }
        
        h2, h3 {
            color: #1e88e5;
        }

        /* Card Styling */
        .card {
            background-color: #1e1e1e;
            border: 1px solid #444;
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 20px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }

        .card-icon {
            font-size: 30px;
            color: #1e88e5;
            margin-right: 10px;
            vertical-align: middle;
        }

        /* Text Styling */
        p {
            line-height: 1.6;
        }

        /* Responsive */
        @media (max-width: 768px) {
            main {
                padding: 10px;
            }

            .card {
                padding: 15px;
            }
        }
    </style>
    
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>

        <!-- Introduction Card -->
        <div class="card">
            <h3><span class="card-icon">🌍</span>Welcome to Smart Travel Assistant</h3>
            <p>
                Smart Travel Assistant is your one-stop solution for discovering the best places to stay, dine, and explore. 
                Whether you're a traveler seeking a luxurious hotel, a foodie searching for top-notch restaurants, or someone 
                looking for exciting things to do in a new city, we've got you covered.
            </p>
        </div>

        <!-- Hotels Card -->
        <div class="card">
            <h3><span class="card-icon">🏨</span>Hotels</h3>
            <p>
                Our platform offers comprehensive information on a wide range of hotels, from budget-friendly options to luxury resorts, 
                ensuring you find the perfect place to stay.
            </p>
        </div>

        <!-- Restaurants Card -->
        <div class="card">
            <h3><span class="card-icon">🍴</span>Restaurants</h3>
            <p>
                We provide detailed reviews and recommendations for restaurants, helping you enjoy the best culinary experiences during your travels.
            </p>
        </div>

        <!-- Things to Do Card -->
        <div class="card">
            <h3><span class="card-icon">🎡</span>Things to Do</h3>
            <p>
                Discover the most popular attractions and activities in your destination. Whether you're looking for cultural experiences, 
                outdoor adventures, or family-friendly activities, our platform offers a curated selection of things to do, ensuring you make the most of your trip.
            </p>
        </div>

        <!-- Conclusion Card -->
        <div class="card">
            <h3><span class="card-icon">🔍</span>Start Exploring</h3>
            <p>
                Use our search tools to quickly find hotels, restaurants, and attractions that suit your preferences. 
                Start planning your next adventure with Smart Travel Assistant today!
            </p>
        </div>
    </main>
</asp:Content>
