using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;


namespace MovieRentalApp.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string userId { get; set; }

        [MinLength(6)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [MinLength(6)]
        [DataType(DataType.Password)]
        public string? confirmPassword { get; set; }
        public string? Location { get; set; }



        public List<Bookiing> bookiings { get; set; }
    }
}
