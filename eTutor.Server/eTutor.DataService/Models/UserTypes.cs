using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class UserTypes
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UserType { get; set; }
    }
}
