using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Users
{
    public class ApiUserDto
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Your password is limited to {2} to {1} charachters",MinimumLength =6)]
        public string Password { get; set; }
    }

    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} charachters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
