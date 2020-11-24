using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movietoon.Models;
using Movietoon.ViewModels;

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
            if(User.IsInRole(RoleName.AdminMovies))
                return View("List");

            return View("RestrictedList");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerDetailViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("Details", viewModel);
            }

            if (customer.Id == 0)
            {
                customer.DateAdded = DateTime.Now;
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                if (customerInDb == null)
                    return HttpNotFound("Error in the Customer Id");

                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.Email = customer.Email;
                customerInDb.MobilePhone = customer.MobilePhone;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.YearOfBirth = customer.YearOfBirth;
                customerInDb.DateAdded = DateTime.Now;


            }
            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }

        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerDetailViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("Details", viewModel);

        }

        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Edit(int id)
        {
            var customerInDb = _context.Customers.Single(c => c.Id == id);
            if (customerInDb == null)
                HttpNotFound("Error in customer Id");

            var viewModel = new CustomerDetailViewModel
            {
                Customer = customerInDb,
                MembershipTypes = _context.MembershipTypes
            };

            return View("Details", viewModel);

        }
    }
}