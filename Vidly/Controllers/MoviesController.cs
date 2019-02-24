using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name="Shrek" },
                new Movie {Name="Wall-e" },
            };
            var viewModel = new MoviesViewModel()
            {
                Movies = movies
            };
            return View(viewModel);
        }

        public ActionResult Details()
        {
            return View();
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1" },
                new Customer {Name="Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie=movie,
                Customers=customers
            };

            return View(viewModel);           
        }

      
    }
}