using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.DTOs;
using Vidly.Models;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Vidly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        DBModel _context;
        public MoviesController(DBModel context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetMovies(string query)
        {
            
            IQueryable<Movie> list = _context.Movies;
            if (query != null)
                list = _context.Movies.Where(c => c.Name.Contains(query) && c.NumberAvailable > 0);

            var movies =list.Select(c => new MovieDto() { Id = c.Id, Name = c.Name, ReleaseDate = c.ReleaseDate, GenreId = c.GenreId, NumberInStock = c.NumberInStock,Genre=c.Genre });

            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movie =_context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return NotFound();
            MovieDto dto = new MovieDto(movie);
            return Ok(dto);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult CreateMovie(MovieDto mov)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var movie = new Movie() { Id = mov.Id, Name = mov.Name, ReleaseDate = mov.ReleaseDate, GenreId = mov.GenreId, NumberInStock = mov.NumberInStock };
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return Created(new Uri(Request.GetDisplayUrl()+"/"+movie.Id),movie);
        }

        [Microsoft.AspNetCore.Mvc.HttpPut]
        public IActionResult UpdateMovie(int md,MovieDto mov)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == md);
            if (movie == null)
            {
                return NotFound();
            }
            movie.Name = mov.Name;
            movie.NumberInStock = mov.NumberInStock;
            movie.GenreId = mov.GenreId;
            movie.ReleaseDate = mov.ReleaseDate;
            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            
            return Ok();
        }
    }
}
