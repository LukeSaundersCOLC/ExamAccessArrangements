using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class PSALSInfo
    {
        [Key]
        public int StudentDetailID { get; set; }
        public string? SupportStatus { get; set; }
        public string? SupportGroup { get; set; }

    }
}
