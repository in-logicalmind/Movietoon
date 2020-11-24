using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Runtime.InteropServices;
using Movietoon.Models;
using Movietoon.ViewModels;

namespace Movietoon.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Rentals
        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult New()
        {
            return View();
        }
        // [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound("Error when trying to retrieve customer data");

            var viewModel = new RentalViewModel
            {
                Customer = customer,
                Rentals = _context.Rentals
                    .Include(r => r.Movie)
                    .Where(r => r.Customer.Id == id)
                    .ToList()
            };

            return View(viewModel);
        }

        public ActionResult ReportRentMovies(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).Single(m => m.Id == id);
            if (movie == null)
                return HttpNotFound("Error when looking for the movie with the provided id");

            var viewModel = new RentalViewModel
            {
                Movie = movie,
                Rentals = _context.Rentals
                    .Include(r => r.Customer)
                    .Where(r => r.Movie.Id == id)
                    .ToList()
            };

            return View(viewModel);
        }
    }
}