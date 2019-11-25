using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyTutorial.Models;

namespace VidlyTutorial.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Mauli" };

            var customer = new List<Customer>
            {
                new Customer { name = "Customr1"},

                new Customer { name = "Customr2"}
            };

            var veiwmodel = new RandomMovieViewModel
            {
                movie = movie,
                customer = customer
            };

            return View(veiwmodel);
            //return Content("Hello Wotld");
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            return View();
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }


        [Route("movie/released/{year:regex(\\d{4})}/{month:range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}