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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Server=warehouse;Database=WebApplications;Trusted_Connection=True;");
            }
        }
    }
}