using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateEntered { get; set; }
        [Required]
        [Display(Name="Number In Stock")]
        [Range(1,20)]
        public int? NumberInStock { get; set; }
        public int NumberAvailable { get; set; }
        [ForeignKey("Genre")]
        [Display(Name="Genres")]
        [Required]
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
