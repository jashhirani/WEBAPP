using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WEBAPP
{
    public partial class HotelDetail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var hotelId = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(hotelId))
                {
                    LoadHotelDetails(hotelId);
                }
            }
        }

        private void LoadHotelDetails(string hotelId)
{
    string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        try
        {
            string query = "SELECT Name, Description, Link, Amenities, Location, Contact, ImageUrl1, ImageUrl2, ImageUrl3 FROM HotelDetails WHERE HotelId = @HotelId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@HotelId", hotelId);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                HotelName.Text = reader["Name"].ToString();
                HotelDescription.Text = reader["Description"].ToString();
                HotelLink.NavigateUrl = reader["Link"].ToString();
                HotelLink.Text = "Visit Website";
                HotelAmenities.Text = reader["Amenities"].ToString();
                HotelLocation.Text = reader["Location"].ToString();
                HotelContact.Text = reader["Contact"].ToString();

                GenerateCarousel(new string[]
                {
                    reader["ImageUrl1"].ToString(),
                    reader["ImageUrl2"].ToString(),
                    reader["ImageUrl3"].ToString()
                });
            }
            else
            {
                // Handle case when no record is found
                HotelName.Text = "No details available.";
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            // Log the exception or display it on the page
            Response.Write($"Error: {ex.Message}");
        }
    }
}


        private void GenerateCarousel(string[] imageUrls)
        {
            var carouselDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            carouselDiv.Attributes["id"] = "hotelCarousel";
            carouselDiv.Attributes["class"] = "carousel slide";
            carouselDiv.Attributes["data-ride"] = "carousel";

            var carouselIndicators = new System.Web.UI.HtmlControls.HtmlGenericControl("ol");
            carouselIndicators.Attributes["class"] = "carousel-indicators";
            for (int i = 0; i < imageUrls.Length; i++)
            {
                var indicator = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                indicator.Attributes["data-target"] = "#hotelCarousel";
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
            prevControl.Attributes["href"] = "#hotelCarousel";
            prevControl.Attributes["role"] = "button";
            prevControl.Attributes["data-slide"] = "prev";
            prevControl.InnerHtml = "<span class='carousel-control-prev-icon' aria-hidden='true'></span><span class='sr-only'>Previous</span>";
            carouselDiv.Controls.Add(prevControl);

            var nextControl = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            nextControl.Attributes["class"] = "carousel-control-next";
            nextControl.Attributes["href"] = "#hotelCarousel";
            nextControl.Attributes["role"] = "button";
            nextControl.Attributes["data-slide"] = "next";
            nextControl.InnerHtml = "<span class='carousel-control-next-icon' aria-hidden='true'></span><span class='sr-only'>Next</span>";
            carouselDiv.Controls.Add(nextControl);

            HotelImagesPlaceHolder.Controls.Add(carouselDiv);
        }
    }
}
