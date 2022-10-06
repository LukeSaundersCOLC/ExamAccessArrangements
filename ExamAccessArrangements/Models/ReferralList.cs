using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class ReferralList
    {
        [Key]
        public int StudentDetailID { get; set; }
        public string? HashValue { get; set; }
        public int? ALSRequired  { get; set; }
        public int? ALSRequested { get; set; }
        public string? PrimaryDisability { get; set; }
    }
}
