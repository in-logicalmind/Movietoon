using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Movietoon.Models;
using System.Data.Entity;
using AutoMapper;
using Movietoon.Dtos;

namespace Movietoon.Controllers.Api
{
    public class CustomersController : ApiController
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

        // GET /api/customers
        // [Authorize(Roles = RoleName.AdminMovies)]
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);
        
            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.LastName.Contains(query));

            var customers = customersQuery.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        
            return Ok(customers);
        }

        // GET /api/customers/1
        // [Authorize(Roles = RoleName.AdminMovies)]
        public IHttpActionResult GetCustomers(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
        
            if (customer == null)
                return NotFound();

            var customerDto = Mapper.Map<Customer, CustomerDto>(customer);
        
            return Ok(customerDto);
        }
    }
}
