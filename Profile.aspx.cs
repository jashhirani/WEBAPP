using System;
using System.Web.UI;

namespace WEBAPP
{
    public partial class Profile : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProfile();
            }
        }

        private void LoadProfile()
        {
            // Example data. Replace with actual data loading logic.
            FirstNameTextBox.Text = "John";
            LastNameTextBox.Text = "Doe";
            EmailTextBox.Text = "john.doe@example.com";

            // Set default values for other sections
            LanguageDropDownList.SelectedValue = "en";
            ThemeDropDownList.SelectedValue = "light";
        }

        protected void SavePersonalInfoButton_Click(object sender, EventArgs e)
        {
            // Save personal information
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;

            // Implement the save logic here (e.g., save to the database)
            // Provide feedback to the user
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Personal information saved successfully.');", true);
        }

        protected void SaveAccountSettingsButton_Click(object sender, EventArgs e)
        {
            // Save account settings
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            // Implement the save logic here (e.g., save to the database)
            // Provide feedback to the user
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Account settings saved successfully.');", true);
        }

        protected void SavePreferencesButton_Click(object sender, EventArgs e)
        {
            // Save preferences
            string language = LanguageDropDownList.SelectedValue;
            string theme = ThemeDropDownList.SelectedValue;

            // Implement the save logic here (e.g., save to the database)
            // Provide feedback to the user
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Preferences saved successfully.');", true);
        }

        protected void EditProfileButton_Click(object sender, EventArgs e)
        {
            // Navigate to edit profile page or enable editing mode
        }
    }
}
