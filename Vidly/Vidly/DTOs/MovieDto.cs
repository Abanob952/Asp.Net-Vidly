using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public MovieDto()
        {

        }
        public MovieDto(Movie mov)
        {
            this.Id = mov.Id;
            this.Name = mov.Name;
            this.ReleaseDate = mov.ReleaseDate;
            this.NumberInStock = mov.NumberInStock;
            this.GenreId = mov.GenreId;
            this.Genre = mov.Genre;

        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        
        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }
        
        [Display(Name = "Genres")]
        [Required]
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
