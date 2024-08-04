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
                    // Example data
                    switch (thingToDoId)
                    {
                        case "1":
                            ThingToDoImage.ImageUrl = "https://i2.wp.com/wadetours.com/wp-content/uploads/2020/01/Statue-of-Liberty-2-scaled.jpg?resize=1536%2C1024&ssl=1";
                            ThingToDoName.Text = "Statue of Liberty Tour";
                            ThingToDoDescription.Text = "Explore the city's landmarks and history.";
                            ThingToDoLink.NavigateUrl = "https://example.com/statue-of-liberty-tour";
                            break;
                        case "2":
                            ThingToDoImage.ImageUrl = "https://cdn.fodors.com/wp-content/uploads/2018/08/01_Miami-Best-Beaches_SouthBeach5th_shutterstock_520475719.jpg";
                            ThingToDoName.Text = "Miami Beach";
                            ThingToDoDescription.Text = "Relax and enjoy the sun at the beach.";
                            ThingToDoLink.NavigateUrl = "https://example.com/miami-beach";
                            break;
                        case "3":
                            ThingToDoImage.ImageUrl = "https://www.gannett-cdn.com/-mm-/75ae6707cc7f58278cf796e13112c8620651f2d0/c=0-55-2000-1185/local/-/media/2017/07/31/USATODAY/USATODAY/636371137877193438-New-Hampshire.jpg?width=2000&height=1130&fit=crop&format=pjpg&auto=webp";
                            ThingToDoName.Text = "Appalachian Trail Hike";
                            ThingToDoDescription.Text = "Experience nature on a scenic hike.";
                            ThingToDoLink.NavigateUrl = "https://example.com/appalachian-trail";
                            break;
                            // Add more cases as needed
                    }
                }
            }
        }
    }
}
