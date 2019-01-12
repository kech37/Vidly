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
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult Random()
        {
            var movie = new Movie() { name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {name = "Customer 1"},
                new Customer {name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + " " + month);
        }
    }
}