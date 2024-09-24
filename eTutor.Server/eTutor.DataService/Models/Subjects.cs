using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace eTutor.DataService.Models
{
    [ExcludeFromCodeCoverage]
    public class Subjects
    {
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}
