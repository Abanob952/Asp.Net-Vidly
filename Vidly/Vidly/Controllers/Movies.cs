using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Filters;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    [Authenticate]
    public class Movies : Controller
    {
        DBModel _context;
        public Movies(DBModel model)
        {
             _context = model;
        }
        //static List<Movie> movies = new List<Movie>()
        // {
        //     new Movie(){Id=1,Name="Shrek"},
        //     new Movie(){Id=1,Name="Shrek 2"},
        //     new Movie(){Id=1,Name="Shrek 3"}
        // };
        public IActionResult Index()
        {
          var movies =  _context.Movies.Include(m=>m.Genre);
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Where(m=>m.Id==id).Include(m => m.Genre).FirstOrDefault();
            return View(movie);
        }
        [AuthenticateManager]
        public IActionResult New()
        {
            MovieModel model = new MovieModel()
            {
                movie=new Movie(),
                genres = _context.Genres

            };
            return View("Edit",model);
        }
        public IActionResult Edit(int id)
        {
            Movie movie= _context.Movies.SingleOrDefault(c => c.Id == id);
            MovieModel model = new MovieModel()
            {
                movie=movie,
                genres = _context.Genres

            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid) 
            {
                MovieModel model = new MovieModel()
                {
                    movie = movie,
                    genres = _context.Genres

                };
                return View("Edit",model);
             }
            else { 
            if (movie.Id == 0)
            {
                 movie.DateEntered = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                Movie movied = _context.Movies.SingleOrDefault(c => c.Id == movie.Id);
                movied.Name = movie.Name;
                movied.GenreId = movie.GenreId;
                movied.ReleaseDate = movie.ReleaseDate;
                movied.DateEntered = movie.DateEntered;
            }
            _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
