using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models
{
    public class Register
    {
        [Key]
        public string userId { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MinLength(6)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [MinLength(6)]
        [DataType(DataType.Password)]
        public string? confirmPassword { get; set; }
        public string? Location { get; set; }
    }
}
