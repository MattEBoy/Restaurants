using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Restaurants.Models;

namespace Restaurants.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            //this page uses an array object
            return View(Restaurant.GetRestaurant());
        }

        //this uses a custom route
        [HttpGet("Home/sug")]
        public IActionResult Suggestions()
        {
            //I couldnt bring myself to use this format
            //it was just too ugly
            //here is the code proving that I could do it this way
            //I still used a list object
            //but it is a list of restaurants instead of a list of strings
            
            //List<string> restaurantList = new List<string>();

            //restaurantList.Add("Restaurant Name********Phone********Submitter********Dish");
            //foreach (RestaurantSuggestion r in RestaurantSuggestion.RestaurantSuggestions)
            //{
            //    restaurantList.Add(string.Format("{0} {1} {2} {3}", r.RestaurantName, r.RestaurantPhone, r.PersonName, r.FavDish));
            //}
            //return View(restaurantList);



            //this page uses a list object
            return View(RestaurantSuggestion.RestaurantSuggestions);
        }
        [HttpGet]
        public IActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entry(RestaurantSuggestion restaurantSuggestion)
        {
            //if the model has everything entered correctly then show the suggestions view, and add the data, otherwise show the error
            if (ModelState.IsValid)
            {
                RestaurantSuggestion.AddRestaurantSuggestion(restaurantSuggestion);
                return RedirectToAction("sug");
            }
            else
            {
                return View();
            }

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}