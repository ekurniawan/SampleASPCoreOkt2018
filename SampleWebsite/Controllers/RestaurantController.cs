using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleWebsite.Models;

namespace SampleWebsite.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant()
            {
                Id = 1,
                Name = "Sate Klathak Jogja"
            };

            var jsonResult = new JsonResult(model);
            return jsonResult;
        }

        static List<Restaurant> listRest = new List<Restaurant>
        {
                new Restaurant {Id=1,Name="Sate Klathak"},
                new Restaurant {Id=2,Name="Sate Buntel"},
                new Restaurant{Id=3,Name="Bakmi Jawa Mbah Hadi"}
        };

        public IActionResult GetAll()
        {
            //ViewBag.ListRestaurant = listRest;
            return View(listRest);
        }
    }
}