using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class StudentPersonalDetails
    {
        [Key]
        public int SPDID { get; set; }
        [Required]
        public int UserID { get; set; }
        public string AboutYou { get; set; }
        public int StandardID { get; set; }
        public int InstituteID { get; set; }
        public int BoardID { get; set; }
        public string ProfilePhoto { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}
