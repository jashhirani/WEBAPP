using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBAPP
{
    public partial class SiteMaster : MasterPage
    {
        // Site.master.cs
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve the preferred language from session
                string preferredLanguage = Session["PreferredLanguage"] as string;

                // If preferred language is set, apply it
                if (!string.IsNullOrEmpty(preferredLanguage))
                {
                    ApplyLanguagePreference(preferredLanguage);
                }
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            // Apply theme by adding a class to the body tag
            if (HttpContext.Current.Items["PreferredTheme"] != null)
            {
                string theme = HttpContext.Current.Items["PreferredTheme"].ToString();
                BodyTag.Attributes.Add("class", theme);
            }
        }
        private void ApplyLanguagePreference(string language)
        {
            // Logic to apply language preference
            // For example, setting the Culture and UICulture for the page
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
        }

    }
}