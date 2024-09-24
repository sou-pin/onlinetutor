using System.ComponentModel.DataAnnotations;

namespace eTutor.Server.DTO
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
