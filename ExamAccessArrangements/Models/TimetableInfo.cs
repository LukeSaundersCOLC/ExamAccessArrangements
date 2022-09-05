using System.ComponentModel.DataAnnotations;
namespace ExamAccessArrangements.Models
{
    public class TimetableInfo
    {
        [Key]
        public string? Register { get; set; }
        public string? StaffName { get; set; }
    }
}
