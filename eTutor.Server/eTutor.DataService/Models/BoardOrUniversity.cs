using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class BoardOrUniversity
    {
        [Key]
        public int BoardID { get; set; }
        public string BoardName { get; set; }
    }
}
