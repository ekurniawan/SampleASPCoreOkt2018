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
    }
}