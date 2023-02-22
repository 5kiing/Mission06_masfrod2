// Author: Mason Frodsham masfrod2
// Mission 6 Assignment

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        // Includes add movie model
        private AddMovieContext context { get; set; }

        //constructor
        public HomeController(AddMovieContext mContext)
        {
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
            ViewBag.Category = context.Category.ToList();

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
                ViewBag.Category = context.Category.ToList();

                return View();
            }
        }

        // show list of movies
        [HttpGet]
        public IActionResult ListMovies ()
        {
            var movies = context.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = context.Category.ToList();

            var movie = context.Responses.Single(x => x.MovieId == movieid);

            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit (AddMovieResponse am)
        {
            context.Update(am);
            context.SaveChanges();
            return RedirectToAction("ListMovies");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = context.Responses.Single(x => x.MovieId == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete (AddMovieResponse am)
        {
            context.Responses.Remove(am);
            context.SaveChanges();
            return RedirectToAction("ListMovies");
        }
    }
}
