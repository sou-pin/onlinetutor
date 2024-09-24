using System.ComponentModel.DataAnnotations;

namespace eTutor.Server.DTO
{
    public class RegisterDto
    {
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? EmailId { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Phone { get; set; }
        
    }
}
