using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Genre { get; set; }

        public decimal Price { get; set; } 
        public string Rating { get; set; }
    }
}
