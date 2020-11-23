using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Movietoon.Models;

namespace Movietoon.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IHttpActionResult GetMovies(string query = null)
        {
            var movies = _context.Movies.Include(m => m.Genre);
            if (!string.IsNullOrWhiteSpace(query))
                movies = movies.Where(m => m.Title.Contains(query));
            
            return Ok(movies);
        }
    }
}
