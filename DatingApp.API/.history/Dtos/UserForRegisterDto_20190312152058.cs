using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
       [Required]
        public string Username { get; set; }

         [Required]
         [MaxLength(8)]
         [MinLength(4)]
                 public string Password { get; set; }
    }
}