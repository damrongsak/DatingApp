using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "You must specify password between 4 and 8 charactor")]
        public string Password { get; set; }
    }
}