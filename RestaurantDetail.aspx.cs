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
                    switch (restaurantId)
                    {
                        case "1":
                            RestaurantName.Text = "Olive Garden";
                            RestaurantDescription.Text = "Authentic Italian cuisine.";
                            RestaurantLink.NavigateUrl = "https://www.olivegarden.com/home";
                            RestaurantLink.Text = "Visit Olive Garden Website";
                            RestaurantAddress.Text = "123 Pasta St, Rome, Italy";
                            RestaurantContact.Text = "+39 06 1234 5678";
                            RestaurantCuisine.Text = "Italian";
                            RestaurantHours.Text = "Mon-Sun: 11 AM - 10 PM";
                            GenerateCarousel(new string[]
                            {
                                "https://i2.cdn.turner.com/money/dam/assets/150602081313-olive-garden-1024x576.jpg",
                                "https://www.rappler.com/tachyon/2022/09/Front-scaled.jpg?fit=1024%2C687&zoom=1.5",
                                "https://in.images.search.yahoo.com/images/view;_ylt=Awrx_xnYHK9muJkS7X29HAx.;_ylu=c2VjA3NyBHNsawNpbWcEb2lkAzlhZTdkOTNjY2Y3OWIwNTQ4MTJjYmY2MjE4Y2QwYjc4BGdwb3MDMwRpdANiaW5n?back=https%3A%2F%2Fin.images.search.yahoo.com%2Fsearch%2Fimages%3Fp%3DOlive%2BGarden%26ei%3DUTF-8%26type%3DE210IN1492G0%26fr%3Dmcafee%26fr2%3Dp%253As%252Cv%253Ai%252Cm%253Asb-top%26tab%3Dorganic%26ri%3D3&w=1998&h=1241&imgurl=s.yimg.com%2Fuu%2Fapi%2Fres%2F1.2%2FFRISHPokt5czVjxQlMPuKw--%7EB%2FaD0xMjQxO3c9MTk5ODtzbT0xO2FwcGlkPXl0YWNoeW9u%2Fhttp%3A%2F%2Fmedia.zenfs.com%2Fen-US%2Fhomerun%2Fpeople_218%2Ff9d45ec93114d36e30fdf977afb96774&rurl=https%3A%2F%2Fnews.yahoo.com%2Folive-garden-adds-apos-giant-153750666.html&size=413.6KB&p=Olive+Garden&oid=9ae7d93ccf79b054812cbf6218cd0b78&fr2=p%3As%2Cv%3Ai%2Cm%3Asb-top&fr=mcafee&tt=Olive+Garden+Adds+New+%26%2339%3BGiant+Classics%26%2339%3B+to+the+Menu+Including+an+11-Inch+...&b=0&ni=140&no=3&ts=&tab=organic&sigr=pxkJeaB6ml8X&sigb=cejcIK6i.9s_&sigi=ymcBtdVzZgjd&sigt=SgNW7pgvV4g4&.crumb=qBF4v1yPuBF&fr=mcafee&fr2=p%3As%2Cv%3Ai%2Cm%3Asb-top&type=E210IN1492G0"                                
                            });
                            break;
                        case "2":
                            RestaurantName.Text = "Sushi Nakazawa";
                            RestaurantDescription.Text = "Fresh sushi and Japanese dishes.";
                            RestaurantLink.NavigateUrl = "https://www.sushinakazawa.com/";
                            RestaurantLink.Text = "Visit Sushi Nakazawa Website";
                            RestaurantAddress.Text = "456 Sushi Ave, Tokyo, Japan";
                            RestaurantContact.Text = "+81 3-1234-5678";
                            RestaurantCuisine.Text = "Japanese";
                            RestaurantHours.Text = "Mon-Sat: 12 PM - 9 PM";
                            GenerateCarousel(new string[]
                            {
                                "http://farm8.staticflickr.com/7440/12707817925_77ed6c6d81_z.jpg",
                                "https://media.timeout.com/images/105284154/1536/864/image.jpg",
                                "https://i.pinimg.com/originals/42/9c/13/429c13663b993d3b68a2c6656c47a517.jpg"
                            });
                            break;
                        case "3":
                            RestaurantName.Text = "Peter Luger Steak House";
                            RestaurantDescription.Text = "Premium steaks and fine dining.";
                            RestaurantLink.NavigateUrl = "https://peterluger.com/menu";
                            RestaurantLink.Text = "Visit Peter Luger Website";
                            RestaurantAddress.Text = "789 Steakhouse Rd, Brooklyn, NY";
                            RestaurantContact.Text = "+1 718-387-7400";
                            RestaurantCuisine.Text = "Steakhouse";
                            RestaurantHours.Text = "Mon-Sun: 12 PM - 11 PM";
                            GenerateCarousel(new string[]
                            {
                                "https://images.fineartamerica.com/images/artworkimages/mediumlarge/3/peter-lugers-steak-house-brooklyn-spencer-mckain.jpg",
                                "https://res.cloudinary.com/the-infatuation/image/upload/q_auto,f_auto/cms/EmilyS_PeterLuger_Interior_001",
                                "https://media.timeout.com/images/105650582/image.jpg"
                            });
                            break;
                            // Add more cases as needed
                    }
                }
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
