// Author: Mason Frodsham masfrod2
// Mission 6 Assignment

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_masfrod2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_masfrod2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        // Includes add movie model
        private AddMovieContext context { get; set; }

        //constructor
        public HomeController(ILogger<HomeController> logger, AddMovieContext mContext)
        {
            _logger = logger;
            context = mContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        // get movie form
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // post movie form to database
        [HttpPost]
        public IActionResult AddMovie(AddMovieResponse am)
        {
            // data validation if statement
            if (ModelState.IsValid)
            {
                context.Add(am);
                context.SaveChanges();
                return View("Confirmation", am);
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
