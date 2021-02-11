using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class Restaurant
    {

        //        An anonymous client has recently been hired by BYU and is new to the Provo area.He is also a
        //foodie.He is looking for a web app that will list out the Top 5 restaurants in the Provo area.As
        //he is new to the area, he needs the list to be pre-populated with your Top 5 favorite restaurants he
        //ought to try. The following information should be listed:
        //• Rank
        //• Restaurant Name
        //• Favorite Dish
        //• Address
        //• Restaurant Phone #
        //• Link to Website

        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavDish { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string RestaurantPhone { get; set; }
        public string? Link { get; set; }

        public Restaurant(int rank, string restName, string favDish, string address, string restPhone, string link)
        {
            this.Rank = rank;
            this.RestaurantName = restName;
            this.FavDish = favDish;
            this.Address = address;
            this.RestaurantPhone = restPhone;
            //cunstructor handles null value passed in
            this.Link = link ?? "Coming soon.";
        }

        public static Restaurant[] GetRestaurant()
        {
            Restaurant r1 = new Restaurant(1, "Cafe Rio", "Salad", "2121 E Provo St.", "8018018011", "https://www.caferio.com");
            Restaurant r2 = new Restaurant(2, "JCW's", "Bacon Burger", "2131 E Provo St.", "8018018011", "https://www.jcws.com");
            Restaurant r3 = new Restaurant(3, "Matt's Backyard Grill", null, "100 S 1090 E", "8018018011", null);
            Restaurant r4 = new Restaurant(4, "Chik-fil-A", "Spicy Chicken Sandwich", "3331 E Provo St.", "8018018011", null);
            Restaurant r5 = new Restaurant(5, "Costco", null, "1020 S 120 E", "8018018011", "https://www.costco.com");
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
