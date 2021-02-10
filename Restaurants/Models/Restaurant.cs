using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class Restaurant
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public String RestaurantName { get; set; }
        public String FavDish { get; set; }
        [Required]
        public String Address { get; set; }
        public String RestaurantPhone { get; set; }
        public String Link { get; set; }

        public static Restaurant GetRestaurant()
        {

            return new Restaurant[](null);
        }
    }
}
