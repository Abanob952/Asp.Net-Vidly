using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Controllers;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerMovies
    {

        public int CustomerId { get; set; }
        public List<int> MoviesId { get; set; }
    }
}
