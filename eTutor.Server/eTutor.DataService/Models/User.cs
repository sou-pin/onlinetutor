using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace eTutor.DataService.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int UserTypeID { get; set; }
        [Required]
        public string? EmailID { get; set; }
        [Required]
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        [Required]
        public string? Phone { get; set; }
        public bool IsEmailVerified { get; set; } = false;
        public bool IsPhoneVerified { get; set; } = false;

    }
}
