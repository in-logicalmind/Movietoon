using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movietoon.Models;
using Movietoon.ViewModels;

namespace Movietoon.Controllers
{
    public class MoviesController : Controller
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

        // GET: Movies
        public ActionResult Index()
        {
            if(User.IsInRole(RoleName.AdminMovies))
                return View("List");

            return View("RestrictedList");
        }

        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Details()
        {
            var viewModel = new MovieDetailViewModel
            {
                Movie = new Movie(),
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Save(MovieDetailViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Details", viewModel);
            }

            if (viewModel.Movie.Id == 0)
            {
                viewModel.Movie.DateAdded = DateTime.Today;
                _context.Movies.Add(viewModel.Movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == viewModel.Movie.Id);
                if (movieInDb == null)
                    return HttpNotFound("Error in the Movie Id");

                movieInDb.Title = viewModel.Movie.Title;
                movieInDb.GenreId = viewModel.Movie.GenreId;
                movieInDb.ReleaseYear = viewModel.Movie.ReleaseYear;
                movieInDb.Price = viewModel.Movie.Price;
                movieInDb.AmountAvailable = viewModel.Movie.AmountAvailable;

                movieInDb.DateAdded = DateTime.Today;
            }

            
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.AdminMovies)]
        public ActionResult Edit(int id)
        {
            var movieInDb = _context.Movies.Single(m => m.Id == id);
            if (movieInDb == null)
                return HttpNotFound("Error in the Movie Id");
            var viewModel = new MovieDetailViewModel
            {
                Movie = movieInDb,
                Genres = _context.Genres.ToList()
            };
            return View("Details", viewModel);
        }
    }
}