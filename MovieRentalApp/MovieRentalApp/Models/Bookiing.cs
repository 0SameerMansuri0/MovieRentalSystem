using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentalApp.Models
{
    public class Bookiing
    {
        [Key]
        public int bookingId { get; set; }
        [ForeignKey("movie")]
        [Required]
        public int movieId { get; set; }

        [ForeignKey("user")] 
        [Required]
        public string userId { get; set; }
       
        [Required]

        public string? movieName { get; set; }

        public int? moviePrice { get; set; }

        public Movie? movie { get; set; }
        public User? user { get; set; }
       
    }
}
