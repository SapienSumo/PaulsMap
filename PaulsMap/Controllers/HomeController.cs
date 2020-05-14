using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaulsMap.Models;

namespace PaulsMap.Controllers
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
            return View();
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

        public ActionResult Details()
        {
            return View();
        }
        //To Animate the Google Map. Atemmpt to add icon animation but ran out of time
        //Reference: https://developers.google.com/maps/documentation/javascript/examples/map-language
        public ActionResult Animate()
        {
            return View();
        }
        
        public ActionResult Icon()
        {
            //Would have created a different Icon view to deal with the animation
            return View();
        }
        public ActionResult Steet()
        {
            // The main view to display the map and search functionality. Referencing View "Steet"
            return View();
        }
    }
    }
