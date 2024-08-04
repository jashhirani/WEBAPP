using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WEBAPP
{
    public partial class Search : Page
    {
        // Example data. Replace this with your actual data source.
        private List<SearchItem> searchItems = new List<SearchItem>
        {
            new SearchItem { Name = "Statue of Liberty Tour", Url = "~/ThingToDoDetail.aspx?id=1" },
            new SearchItem { Name = "Miami Beach", Url = "~/ThingToDoDetail.aspx?id=2" },
            new SearchItem { Name = "Appalachian Trail Hike", Url = "~/ThingToDoDetail.aspx?id=3" },
            new SearchItem { Name = "The Ritz-Carlton", Url = "~/HotelDetail.aspx?id=1" },
            new SearchItem { Name = "Motel 6", Url = "~/HotelDetail.aspx?id=2" },
            new SearchItem { Name = "Kimpton Hotel", Url = "~/HotelDetail.aspx?id=3" },
            new SearchItem { Name = "Olive Garden", Url = "~/RestaurantDetail.aspx?id=1" },
            new SearchItem { Name = "Sushi Nakazawa", Url = "~/RestaurantDetail.aspx?id=2" },
            new SearchItem { Name = "Peter Luger Steak House", Url = "~/RestaurantDetail.aspx?id=3" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Any additional logic if needed
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            var query = SearchTextBox.Text.Trim().ToLower();
            var result = searchItems.Find(item => item.Name.ToLower().Contains(query));

            if (result != null)
            {
                // Redirect to the page based on the search result
                Response.Redirect(result.Url);
            }
            else
            {
                // Display a message if no results found
                SearchResultsLabel.Text = "No results found. Please try a different search.";
            }
        }
    }

    public class SearchItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
