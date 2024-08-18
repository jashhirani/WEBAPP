<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WEBAPP.Contact" %>

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
            display: flex;
            align-items: center;
        }

        .card-icon {
            font-size: 30px;
            color: #1e88e5;
            margin-right: 20px;
            vertical-align: middle;
        }

        .card-content {
            flex: 1;
        }

        .card-description {
            font-size: 14px;
            color: #a0a0a0;
            margin-top: 10px;
        }

        /* Contact Information Styling */
        address {
            line-height: 1.8;
            font-style: normal;
            margin-bottom: 10px;
        }

        abbr {
            text-transform: uppercase;
            color: #999;
        }

        a {
            color: #1e88e5;
            text-decoration: none;
        }

        a:hover {
            text-decoration: underline;
        }

        /* Responsive */
        @media (max-width: 768px) {
            main {
                padding: 10px;
            }

            .card {
                flex-direction: column;
                align-items: flex-start;
            }

            .card-icon {
                margin-bottom: 10px;
            }
        }
    </style>

    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>

        <!-- Contact Information Card -->
        <div class="card">
            <div class="card-icon">📍</div>
            <div class="card-content">
                <h3>Our Address</h3>
                <address>
                    Shri Vile Parle Kelavani Mandal's<br>

                    Usha Pravin Gandhi College of Arts, Science and Commerce,
                    Bhakti Vedanta Swami Marg,
                    JVPD Scheme, Vile Parle (West),
                    Mumbai 400 056.<br>
                    Maharashtra<br>
                    India<br>
                    <abbr title="Phone">P:</abbr> 022-42332041- 44
                </address>
                <p class="card-description">Located in the heart of Redmond, our headquarters is where innovation meets excellence. Visit us to explore more about what we do and how we can help you achieve your goals.</p>
            </div>
        </div>

        <!-- Support and Marketing Contact Card -->
        <div class="card">
            <div class="card-icon">✉️</div>
            <div class="card-content">
                <h3>Contact Us</h3>
                <address>
                    <strong>College:</strong> <a href="mailto:Support@example.com">info@upgcm.ac.in</a><br />
                    <strong>Created By:</strong> <a href="mailto:Marketing@example.com">Jashrhirani53@gmail.com</a>
                </address>
                <p class="card-description">Have questions or need assistance? Reach out to our support team, or contact our marketing department for business inquiries and partnership opportunities.</p>
            </div>
        </div>
    </main>
</asp:Content>
