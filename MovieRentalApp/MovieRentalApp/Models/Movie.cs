using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string?  MovieName { get; set; }

        [Required]
        public string? MovieCategory { get; set;}

        [Required]
        public int MovieRentPrice { get; set;}
        public string ? ActorName { get; set; }

        public string? DirectorName { get; set; }

        public string ImagePath { get; set; }


        public List<Bookiing>? Bookiings { get; set;}
    }
}
