using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyTutorial.Models;

namespace VidlyTutorial.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }


    }
}