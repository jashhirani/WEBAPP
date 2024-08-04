using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WEBAPP
{

    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindHotels();
                BindRestaurants();
                BindThingsToDo();
            }
        }

        private void BindHotels()
        {
            var hotels = new List<CategoryItem>
            {
                new CategoryItem { Name = "The Ritz-Carlton", Description = "5-star luxury hotel with amazing amenities.", ImageUrl = "http://www.hospitalitynet.org/picture/153045051.jpg", Link = "HotelDetail.aspx?id=1" },
                new CategoryItem { Name = "Motel 6", Description = "Affordable hotel with basic facilities.", ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/28/31/c6/be/m-ext.jpg?w=1100&h=-1&s=1", Link = "HotelDetail.aspx?id=2" },
                new CategoryItem { Name = "Kimpton Hotel", Description = "Charming hotel with unique decor.", ImageUrl = "https://digital.ihg.com/is/image/ihg/kimpton-tokyo-6874078618-16x9?", Link = "HotelDetail.aspx?id=3" }
            };

            HotelsRepeater.DataSource = hotels;
            HotelsRepeater.DataBind();
        }

        private void BindRestaurants()
        {
            var restaurants = new List<CategoryItem>
            {
                new CategoryItem { Name = "Olive Garden", Description = "Authentic Italian cuisine.", ImageUrl = "https://i2.cdn.turner.com/money/dam/assets/150602081313-olive-garden-1024x576.jpg", Link = "RestaurantDetail.aspx?id=1" },
                new CategoryItem { Name = "Sushi Nakazawa", Description = "Fresh sushi and Japanese dishes.", ImageUrl = "http://farm8.staticflickr.com/7440/12707817925_77ed6c6d81_z.jpg", Link = "RestaurantDetail.aspx?id=2" },
                new CategoryItem { Name = "Peter Luger Steak House", Description = "Premium steaks and fine dining.", ImageUrl = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/3/peter-lugers-steak-house-brooklyn-spencer-mckain.jpg", Link = "RestaurantDetail.aspx?id=3" }
            };

            RestaurantsRepeater.DataSource = restaurants;
            RestaurantsRepeater.DataBind();
        }

        private void BindThingsToDo()
        {
            var thingsToDo = new List<CategoryItem>
            {
                new CategoryItem { Name = "Statue of Liberty Tour", Description = "Explore the city's landmarks and history.", ImageUrl = "https://i2.wp.com/wadetours.com/wp-content/uploads/2020/01/Statue-of-Liberty-2-scaled.jpg?resize=1536%2C1024&ssl=1", Link = "ThingToDoDetail.aspx?id=1" },
                new CategoryItem { Name = "Miami Beach", Description = "Relax and enjoy the sun at the beach.", ImageUrl = "https://cdn.fodors.com/wp-content/uploads/2018/08/01_Miami-Best-Beaches_SouthBeach5th_shutterstock_520475719.jpg", Link = "ThingToDoDetail.aspx?id=2" },
                new CategoryItem { Name = "Appalachian Trail Hike", Description = "Experience nature on a scenic hike.", ImageUrl = "https://www.gannett-cdn.com/-mm-/75ae6707cc7f58278cf796e13112c8620651f2d0/c=0-55-2000-1185/local/-/media/2017/07/31/USATODAY/USATODAY/636371137877193438-New-Hampshire.jpg?width=2000&height=1130&fit=crop&format=pjpg&auto=webp", Link = "ThingToDoDetail.aspx?id=3" }
            };

            ThingsToDoRepeater.DataSource = thingsToDo;
            ThingsToDoRepeater.DataBind();
        }
    }



    public class CategoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
    }

}