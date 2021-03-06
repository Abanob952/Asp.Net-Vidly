using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        DBModel _context;
        public RentalsController(DBModel model)
        {
            _context = model;
        }

        [HttpGet]
        public IActionResult Get()
        {
          return Ok(_context.Customers.ToList());

        }
        [HttpPost]
        public IActionResult Rent(CustomerMovies cm)
        {
            foreach(int id in cm.MoviesId)
            {
                Rental rental = new Rental();
                rental.CustomerId = cm.CustomerId;
                rental.DateRented = DateTime.Now;
                rental.MovieId = id;
                _context.Movies.SingleOrDefault(c => c.Id == id).NumberAvailable--;
                _context.Rentals.Add(rental);
                _context.SaveChanges();
            }
            return Ok();
        }
    }
}
