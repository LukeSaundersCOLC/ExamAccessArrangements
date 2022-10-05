using ExamAccessArrangements.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamAccessArrangements.Data
{
    public partial class ProSolutionContext : DbContext
    {
        public ProSolutionContext(DbContextOptions<ProSolutionContext> options)
            : base(options)
        {
        }


        public virtual DbSet <Student> Students{ get; set; } = null!;
        public virtual DbSet<EnrolmentInfo> Enrolment { get; set; } = null!;
        public virtual DbSet<TimetableInfo> Timetables { get; set; } = null!;
        public virtual DbSet<PSALSInfo> PSALS { get; set; } = null!;


    }
}