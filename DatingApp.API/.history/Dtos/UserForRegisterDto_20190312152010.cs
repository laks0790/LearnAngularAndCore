using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
       [Required]
        public string Username { get; set; }

         [Required]
         [Password]
        public string Password { get; set; }
    }
}