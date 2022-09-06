using ExamAccessArrangements.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProfileSummary.Data
{
    public partial class ProSolutionContext : DbContext
    {
        public ProSolutionContext(DbContextOptions<ProSolutionContext> options)
            : base(options)
        {
        }
        public virtual DbSet<StudentInfo> Student { get; set; } = null!;
        public virtual DbSet<EnrolmentInfo> Enrolment { get; set; } = null!;
        public virtual DbSet<TimetableInfo> Timetables { get; set; } = null!;
        public virtual DbSet<PSALSInfo> PSALS { get; set; } = null!;
        
    }
}