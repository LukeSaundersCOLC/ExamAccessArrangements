using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class EnrolmentInfo
    {
        [Key]
        public string? CourseCode { get; set; }
        public string? GroupCode { get; set; }
        public string? CompletionStatus { get; set; }
    }
}
