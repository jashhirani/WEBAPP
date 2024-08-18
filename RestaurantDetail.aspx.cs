using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WEBAPP
{
    public partial class RestaurantDetail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var restaurantId = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(restaurantId))
                {
                    LoadRestaurantDetails(restaurantId);
                }
            }
        }

        private void LoadRestaurantDetails(string restaurantId)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Description, Link, Address, Contact, Cuisine, Hours, ImageUrl1, ImageUrl2, ImageUrl3 FROM RestaurantDetails WHERE RestaurantId = @RestaurantId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RestaurantId", restaurantId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    RestaurantName.Text = reader["Name"].ToString();
                    RestaurantDescription.Text = reader["Description"].ToString();
                    RestaurantLink.NavigateUrl = reader["Link"].ToString();
                    RestaurantLink.Text = "Visit Restaurant Website";
                    RestaurantAddress.Text = reader["Address"].ToString();
                    RestaurantContact.Text = reader["Contact"].ToString();
                    RestaurantCuisine.Text = reader["Cuisine"].ToString();
                    RestaurantHours.Text = reader["Hours"].ToString();

                    GenerateCarousel(new string[]
                    {
                        reader["ImageUrl1"].ToString(),
                        reader["ImageUrl2"].ToString(),
                        reader["ImageUrl3"].ToString()
                    });
                }
                conn.Close();
            }
        }


        private void GenerateCarousel(string[] imageUrls)
        {
            var carouselDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            carouselDiv.Attributes["id"] = "restaurantCarousel";
            carouselDiv.Attributes["class"] = "carousel slide";
            carouselDiv.Attributes["data-ride"] = "carousel";

            var carouselIndicators = new System.Web.UI.HtmlControls.HtmlGenericControl("ol");
            carouselIndicators.Attributes["class"] = "carousel-indicators";
            for (int i = 0; i < imageUrls.Length; i++)
            {
                var indicator = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                indicator.Attributes["data-target"] = "#restaurantCarousel";
                indicator.Attributes["data-slide-to"] = i.ToString();
                if (i == 0) indicator.Attributes["class"] = "active";
                carouselIndicators.Controls.Add(indicator);
            }
            carouselDiv.Controls.Add(carouselIndicators);

            var carouselInner = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            carouselInner.Attributes["class"] = "carousel-inner";
            for (int i = 0; i < imageUrls.Length; i++)
            {
                var carouselItem = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                carouselItem.Attributes["class"] = i == 0 ? "carousel-item active" : "carousel-item";

                var img = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
                img.Attributes["class"] = "d-block w-100";
                img.Attributes["src"] = imageUrls[i];
                carouselItem.Controls.Add(img);

                carouselInner.Controls.Add(carouselItem);
            }
            carouselDiv.Controls.Add(carouselInner);

            var prevControl = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            prevControl.Attributes["class"] = "carousel-control-prev";
            prevControl.Attributes["href"] = "#restaurantCarousel";
            prevControl.Attributes["role"] = "button";
            prevControl.Attributes["data-slide"] = "prev";
            prevControl.InnerHtml = "<span class='carousel-control-prev-icon' aria-hidden='true'></span><span class='sr-only'>Previous</span>";
            carouselDiv.Controls.Add(prevControl);

            var nextControl = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            nextControl.Attributes["class"] = "carousel-control-next";
            nextControl.Attributes["href"] = "#restaurantCarousel";
            nextControl.Attributes["role"] = "button";
            nextControl.Attributes["data-slide"] = "next";
            nextControl.InnerHtml = "<span class='carousel-control-next-icon' aria-hidden='true'></span><span class='sr-only'>Next</span>";
            carouselDiv.Controls.Add(nextControl);

            RestaurantImagesPlaceHolder.Controls.Add(carouselDiv);
        }
    }
}
