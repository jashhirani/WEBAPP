using System;
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
                    // Example data
                    switch (restaurantId)
                    {
                        case "1":
                            RestaurantImage.ImageUrl = "https://i2.cdn.turner.com/money/dam/assets/150602081313-olive-garden-1024x576.jpg";
                            RestaurantName.Text = "Olive Garden";
                            RestaurantDescription.Text = "Authentic Italian cuisine.";
                            RestaurantLink.NavigateUrl = "https://example.com/olive-garden";
                            break;
                        case "2":
                            RestaurantImage.ImageUrl = "http://farm8.staticflickr.com/7440/12707817925_77ed6c6d81_z.jpg";
                            RestaurantName.Text = "Sushi Nakazawa";
                            RestaurantDescription.Text = "Fresh sushi and Japanese dishes.";
                            RestaurantLink.NavigateUrl = "https://example.com/sushi-nakazawa";
                            break;
                        case "3":
                            RestaurantImage.ImageUrl = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/3/peter-lugers-steak-house-brooklyn-spencer-mckain.jpg";
                            RestaurantName.Text = "Peter Luger Steak House";
                            RestaurantDescription.Text = "Premium steaks and fine dining.";
                            RestaurantLink.NavigateUrl = "https://example.com/peter-luger";
                            break;
                            // Add more cases as needed
                    }
                }
            }
        }
    }
}
