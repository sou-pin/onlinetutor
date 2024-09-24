using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class Institute
    {
        [Key]
        public int InstituteID { get; set; }
        public string InstituteName { get; set; }
    }
}
