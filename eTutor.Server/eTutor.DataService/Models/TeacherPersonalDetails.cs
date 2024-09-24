using System.ComponentModel.DataAnnotations;

namespace eTutor.DataService.Models
{
    public class TeacherPersonalDetails
    {
        [Key]
        public int TPDID { get; set; }
        [Required]
        public int UserID { get; set; }
        public string AboutYou { get; set; }
        public string Qualification { get; set; }
        public int TeachingExperience { get; set; }
        public string ProfilePhoto { get; set; }
        public string Profession { get; set; }
        public int ProfessionalExperience { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}
