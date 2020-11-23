using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movietoon.Models;

namespace Movietoon.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View();
        }

        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
                return View("Save", customer);

            _context.Customers.Add(customer);

            return RedirectToAction("Index","Home");
        }



    }
}