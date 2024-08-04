<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WEBAPP.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Profile</h2>
    <div class="row">
        <!-- Profile Sidebar -->
        <div class="col-md-3">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">User Name</h4>
                    <p class="card-text">user@example.com</p>
                    <asp:Button ID="EditProfileButton" runat="server" CssClass="btn btn-primary btn-block" Text="Edit Profile" OnClick="EditProfileButton_Click" />
                </div>
            </div>
            <div class="list-group mt-3">
                <a href="javascript:void(0);" class="list-group-item list-group-item-action" onclick="showSection('PersonalInformation')">Personal Information</a>
                <a href="javascript:void(0);" class="list-group-item list-group-item-action" onclick="showSection('AccountSettings')">Account Settings</a>
                <a href="javascript:void(0);" class="list-group-item list-group-item-action" onclick="showSection('Preferences')">Preferences</a>
            </div>
        </div>
        <!-- Profile Content -->
        <div class="col-md-9">
            <!-- Personal Information Section -->
            <div id="PersonalInformation" class="profile-section">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Personal Information</h5>
                        <form>
                            <div class="form-group">
                                <label for="FirstName">First Name</label>
                                <asp:TextBox ID="FirstNameTextBox" runat="server" CssClass="form-control" />
                            </div>
                            <div class="form-group">
                                <label for="LastName">Last Name</label>
                                <asp:TextBox ID="LastNameTextBox" runat="server" CssClass="form-control" />
                            </div>
                            <div class="form-group">
                                <label for="Email">Email</label>
                                <asp:TextBox ID="EmailTextBox" runat="server" CssClass="form-control" />
                            </div>
                            <asp:Button ID="SavePersonalInfoButton" runat="server" CssClass="btn btn-success" Text="Save" OnClick="SavePersonalInfoButton_Click" />
                        </form>
                    </div>
                </div>
            </div>

            <!-- Account Settings Section -->
            <div id="AccountSettings" class="profile-section" style="display:none;">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Account Settings</h5>
                        <form>
                            <div class="form-group">
                                <label for="Password">Password</label>
                                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" CssClass="form-control" />
                            </div>
                            <div class="form-group">
                                <label for="ConfirmPassword">Confirm Password</label>
                                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password" CssClass="form-control" />
                            </div>
                            <asp:Button ID="SaveAccountSettingsButton" runat="server" CssClass="btn btn-success" Text="Save" OnClick="SaveAccountSettingsButton_Click" />
                        </form>
                    </div>
                </div>
            </div>

            <!-- Preferences Section -->
            <div id="Preferences" class="profile-section" style="display:none;">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Preferences</h5>
                        <form>
                            <div class="form-group">
                                <label for="Language">Preferred Language</label>
                                <asp:DropDownList ID="LanguageDropDownList" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="English" Value="en" />
                                    <asp:ListItem Text="Spanish" Value="es" />
                                    <asp:ListItem Text="French" Value="fr" />
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="Theme">Preferred Theme</label>
                                <asp:DropDownList ID="ThemeDropDownList" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="Light" Value="light" />
                                    <asp:ListItem Text="Dark" Value="dark" />
                                </asp:DropDownList>
                            </div>
                            <asp:Button ID="SavePreferencesButton" runat="server" CssClass="btn btn-success" Text="Save" OnClick="SavePreferencesButton_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function showSection(sectionId) {
            // Hide all sections
            document.querySelectorAll('.profile-section').forEach(function(section) {
                section.style.display = 'none';
            });

            // Show the selected section
            document.getElementById(sectionId).style.display = 'block';
        }
    </script>
</asp:Content>
