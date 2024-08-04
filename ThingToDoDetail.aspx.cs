using System;
using System.Web.UI;

namespace WEBAPP
{
    public partial class ThingToDoDetail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var thingToDoId = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(thingToDoId))
                {
                    switch (thingToDoId)
                    {
                        case "1":
                            ThingToDoName.Text = "Statue of Liberty Tour";
                            ThingToDoDescription.Text = "Explore the city's landmarks and history.";
                            ThingToDoLink.NavigateUrl = "https://www.viator.com/tours/New-York-City/Statue-of-Liberty-Express-Optional-Pedestal/d687-74526P19";
                            ThingToDoLink.Text = "Visit Statue of Liberty Tour Website";
                            ThingToDoLocation.Text = "New York, NY";
                            ThingToDoDuration.Text = "2 hours";
                            ThingToDoContact.Text = "info@libertytour.com";
                            GenerateCarousel(new string[]
                            {
                                "https://i2.wp.com/wadetours.com/wp-content/uploads/2020/01/Statue-of-Liberty-2-scaled.jpg?resize=1536%2C1024&ssl=1",
                                "https://images.myguide-cdn.com/york/companies/private-statue-of-liberty-and-ellis-island-tour/large/private-statue-of-liberty-and-ellis-island-tour-534750.jpg",
                                "http://www.getsready.com/wp-content/uploads/2016/03/night-view-of-statue-of-liberty.jpg"
                            });
                            break;
                        case "2":
                            ThingToDoName.Text = "Miami Beach";
                            ThingToDoDescription.Text = "Relax and enjoy the sun at the beach.";
                            ThingToDoLink.NavigateUrl = "https://www.viator.com/Miami-attractions/Miami-Beach/overview/d662-a1221";
                            ThingToDoLink.Text = "Visit Miami Beach Website";
                            ThingToDoLocation.Text = "Miami, FL";
                            ThingToDoDuration.Text = "Half day";
                            ThingToDoContact.Text = "info@miamibeach.com";
                            GenerateCarousel(new string[]
                            {
                                "https://cdn.fodors.com/wp-content/uploads/2018/08/01_Miami-Best-Beaches_SouthBeach5th_shutterstock_520475719.jpg",
                                "https://www.tourist-destinations.com/wp-content/uploads/2011/12/aerial-beach-miami-florida-1536x1024.jpg",
                                "https://www.tripsavvy.com/thmb/YZth1a9GW_7TnHswboSgbXKDlfc=/2095x1431/filters:no_upscale():max_bytes(150000):strip_icc()/miamibeachatnight-5b0df8248023b90036f96119.jpg"
                            });
                            break;
                        case "3":
                            ThingToDoName.Text = "Appalachian Trail Hike";
                            ThingToDoDescription.Text = "Experience nature on a scenic hike.";
                            ThingToDoLink.NavigateUrl = "https://appalachiantrail.org/explore/hike-the-a-t/";
                            ThingToDoLink.Text = "Visit Appalachian Trail Website";
                            ThingToDoLocation.Text = "Appalachian Mountains";
                            ThingToDoDuration.Text = "1 day";
                            ThingToDoContact.Text = "info@appalachiantrail.com";
                            GenerateCarousel(new string[]
                            {
                                "https://www.gannett-cdn.com/-mm-/75ae6707cc7f58278cf796e13112c8620651f2d0/c=0-55-2000-1185/local/-/media/2017/07/31/USATODAY/USATODAY/636371137877193438-New-Hampshire.jpg?width=2000&height=1130&fit=crop&format=pjpg&auto=webp",
                                "https://photos.thetrek.co/wp-content/uploads/2017/08/IMG_2213.jpg",
                                "https://149650922.v2.pressablecdn.com/wp-content/uploads/2022/09/Franconia-Ridge-Appalachian-Trail-in-New-Hampshire-scaled.jpg"
                            });
                            break;
                            
                    }
                }
            }
        }

        private void GenerateCarousel(string[] imageUrls)
        {
            var carouselDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            carouselDiv.Attributes["id"] = "thingToDoCarousel";
            carouselDiv.Attributes["class"] = "carousel slide";
            carouselDiv.Attributes["data-ride"] = "carousel";

            var carouselIndicators = new System.Web.UI.HtmlControls.HtmlGenericControl("ol");
            carouselIndicators.Attributes["class"] = "carousel-indicators";
            for (int i = 0; i < imageUrls.Length; i++)
            {
                var indicator = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                indicator.Attributes["data-target"] = "#thingToDoCarousel";
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
            prevControl.Attributes["href"] = "#thingToDoCarousel";
            prevControl.Attributes["role"] = "button";
            prevControl.Attributes["data-slide"] = "prev";
            prevControl.InnerHtml = "<span class='carousel-control-prev-icon' aria-hidden='true'></span><span class='sr-only'>Previous</span>";
            carouselDiv.Controls.Add(prevControl);

            var nextControl = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            nextControl.Attributes["class"] = "carousel-control-next";
            nextControl.Attributes["href"] = "#thingToDoCarousel";
            nextControl.Attributes["role"] = "button";
            nextControl.Attributes["data-slide"] = "next";
            nextControl.InnerHtml = "<span class='carousel-control-next-icon' aria-hidden='true'></span><span class='sr-only'>Next</span>";
            carouselDiv.Controls.Add(nextControl);

            ThingToDoImagesPlaceHolder.Controls.Add(carouselDiv);
        }
    }
}
