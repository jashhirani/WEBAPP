using System;
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
                    switch (hotelId)
                    {
                        case "1":
                            HotelName.Text = "The Ritz-Carlton";
                            HotelDescription.Text = "5-star luxury hotel with amazing amenities.";
                            HotelLink.NavigateUrl = "https://www.ritzcarlton.com/";
                            HotelLink.Text = "Visit The Ritz-Carlton Website";
                            HotelAmenities.Text = "Spa, Pool, Fitness Center, Free Wi-Fi";
                            HotelLocation.Text = "New York, NY";
                            HotelContact.Text = "info@ritz-carlton.com";
                            GenerateCarousel(new string[]
                            {
                                "http://www.hospitalitynet.org/picture/153045051.jpg",
                                "https://images.squarespace-cdn.com/content/v1/52ccee75e4b00bc0dba03f46/1499256269167-ZFVZVDIGEKE6ZH1VRUWZ/ke17ZwdGBToddI8pDm48kEP3XILZbd6clkwwwPPDzGJ7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1USJfBMlwhtiUUFKQ2Qtzx-UONIfB-9RFWha3Hf_VomFI5ck0MD3_q0rY3jFJjjoLbQ/image-asset.jpeg",
                                "https://global-uploads.webflow.com/5cf16f74881a650c03c2f354/5ea1d4535b00b8683a6625da_50373940_2600x1585.jpg"
                            });
                            break;
                        case "2":
                            HotelName.Text = "Motel 6";
                            HotelDescription.Text = "Affordable hotel with basic facilities.";
                            HotelLink.NavigateUrl = "https://www.motel6.com/en/home.html";
                            HotelLink.Text = "Visit Motel 6 Website";
                            HotelAmenities.Text = "Free Parking, Pet-Friendly, Free Wi-Fi";
                            HotelLocation.Text = "Los Angeles, CA";
                            HotelContact.Text = "info@motel6.com";
                            GenerateCarousel(new string[]
                            {
                                "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/28/31/c6/be/m-ext.jpg?w=1100&h=-1&s=1",
                                "https://az712897.vo.msecnd.net/images/full/09c6faac-e11f-4929-aa4a-d84631a27f30.jpeg",
                                "https://photos.prnewswire.com/prnfull/20151101/282647?max=400",
                                "https://pix10.agoda.net/hotelImages/165/165993/165993_16052414360042671450.jpg?ca=6&ce=1&s=1024x768"
                            });
                            break;
                        case "3":
                            HotelName.Text = "Kimpton Hotel";
                            HotelDescription.Text = "Charming hotel with unique decor.";
                            HotelLink.NavigateUrl = "https://www.guestreservations.com/kimpton-journeyman-hotel-milwaukee/booking";
                            HotelLink.Text = "Visit Kimpton Hotel Website";
                            HotelAmenities.Text = "Bar, Restaurant, Free Wi-Fi";
                            HotelLocation.Text = "San Francisco, CA";
                            HotelContact.Text = "info@kimptonhotel.com";
                            GenerateCarousel(new string[]
                            {
                                "https://digital.ihg.com/is/image/ihg/kimpton-tokyo-6874078618-16x9?",
                                "http://russell-hotel-london.hotel-ds.com/data/Photos/OriginalPhoto/7006/700611/700611937.JPEG",
                                "https://i.ytimg.com/vi/oMXUPcVwNas/maxresdefault.jpg"
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
