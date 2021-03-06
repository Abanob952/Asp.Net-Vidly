using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieModel
    {
        public Movie movie { get; set; }
        public IEnumerable<Genre> genres { get; set; }
    }
}
