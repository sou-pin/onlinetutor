using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class Standard
    {
        [Key]
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
