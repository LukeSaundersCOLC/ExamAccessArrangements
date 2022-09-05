using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class StudentInfo
    {
        [Key]
        public int RefNo { get; set; }
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public string? KnownAs { get; set; }
        public string? Username { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
