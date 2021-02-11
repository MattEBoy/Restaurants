using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Models
{
    public class RestaurantSuggestion
    {
        //nothing was defined in this class as required, but the phone number must work
        public string RestaurantName { get; set; }
        public string FavDish { get; set; }
        public string PersonName { get; set; }
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string RestaurantPhone { get; set; }


        //array of restaurants
        private static List<RestaurantSuggestion> restaurantSuggestions = new List<RestaurantSuggestion>();

        public static IEnumerable<RestaurantSuggestion> RestaurantSuggestions => restaurantSuggestions;
        //adds to restaurants
        public static void AddRestaurantSuggestion(RestaurantSuggestion restaurantSuggestion)
        {
            restaurantSuggestions.Add(restaurantSuggestion);
        }
    }
}
