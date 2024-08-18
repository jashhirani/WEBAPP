using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT Name, Description, ImageUrl, Link FROM Hotels";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<CategoryItem> hotels = new List<CategoryItem>();
                    while (reader.Read())
                    {
                        hotels.Add(new CategoryItem
                        {
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString(),
                            Link = reader["Link"].ToString()
                        });
                    }
                    HotelsRepeater.DataSource = hotels;
                    HotelsRepeater.DataBind();
                }
            }
        }

        private void BindRestaurants()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT Name, Description, ImageUrl, Link FROM Restaurants";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<CategoryItem> restaurants = new List<CategoryItem>();
                    while (reader.Read())
                    {
                        restaurants.Add(new CategoryItem
                        {
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString(),
                            Link = reader["Link"].ToString()
                        });
                    }
                    RestaurantsRepeater.DataSource = restaurants;
                    RestaurantsRepeater.DataBind();
                }
            }
        }

        private void BindThingsToDo()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            string query = "SELECT Name, Description, ImageUrl, Link FROM ThingsToDo";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<CategoryItem> thingsToDo = new List<CategoryItem>();
                    while (reader.Read())
                    {
                        thingsToDo.Add(new CategoryItem
                        {
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            ImageUrl = reader["ImageUrl"].ToString(),
                            Link = reader["Link"].ToString()
                        });
                    }
                    ThingsToDoRepeater.DataSource = thingsToDo;
                    ThingsToDoRepeater.DataBind();
                }
            }
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
