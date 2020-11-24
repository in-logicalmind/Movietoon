using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using System.Data.Entity;
using Movietoon.Dtos;
using Movietoon.Models;

namespace Movietoon.Controllers.Api
{
    public class RentalsController : ApiController
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

        [HttpPost]
        public IHttpActionResult CreateRentals(RentalDto rentalDto)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);
            if (customer == null)
                return BadRequest("There are not customers for the provided Id");

            if (rentalDto.MovieIds.Count == 0)
                return BadRequest("The provided list of movies is empty");

            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != rentalDto.MovieIds.Count)
                BadRequest("Some movie Id's provided are incorrect or there are not movies for that movie id");

            foreach (var movie in movies)
            {
                if (movie.AvailableForRental == 0)
                    return BadRequest("The movie is not available for renting");

                movie.AvailableForRental--;
                var rental = new Rental
                {
                    Movie = movie,
                    Customer = customer,
                    RentedDate = DateTime.Today
                };
                _context.Rentals.Add(rental);
                _context.SaveChanges();
            }

            return Ok();
        }



        [HttpGet]
        public IHttpActionResult RentalsByUser(int id)
        {
            var rentalsByUser = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .Where(r => r.Customer.Id == id)
                .ToList();

            if (rentalsByUser.Count == 0)
                return NotFound();

            return Ok(rentalsByUser);
        }
    }
}
