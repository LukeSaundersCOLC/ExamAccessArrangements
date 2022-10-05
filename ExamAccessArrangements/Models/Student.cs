using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ExamAccessArrangements.Models
{
    public class Student
    {
        [Key]
        public int  RefNo { get; set; }
        public string? Forename { get; set; }

        internal object FromSqlRaw(string sqlStudentInfo, SqlParameter p1, SqlParameter p2, SqlParameter p3)
        {
            throw new NotImplementedException();
        }
        public string? Surname { get; set; }
        public string? OtherForenames { get; set; }
        public string? KnownAs { get; set; }
        public string? Username { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
