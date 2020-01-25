using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videe.Models;
using Videe.ViewModels;

namespace Videe.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Movies/
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Harry Potter and the Chamber of Secrets" }
            };

            var viewModel = new MoviesListViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        // GET: Movies/Details/id
        public ActionResult Details(int id)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Harry Potter and the Chamber of Secrets" }
            };

            var viewModel = movies.Find(x => x.Id == id);

            return View(viewModel);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}