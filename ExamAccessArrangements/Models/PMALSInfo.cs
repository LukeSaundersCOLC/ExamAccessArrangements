using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class PMALSInfo
    {
        [Key]
        public int RefNo { get; set; }
        public int InClassSupport { get; set; }
        public int EAA { get; set; }
    }
}
