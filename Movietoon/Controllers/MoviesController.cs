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
            return View();
        }

        public ActionResult Details()
        {
            var viewModel = new MovieDetailViewModel
            {
                Movie = new Movie(),
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Save(MovieDetailViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Details", viewModel);

            viewModel.Movie.DateAdded = DateTime.Today;
            _context.Movies.Add(viewModel.Movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}