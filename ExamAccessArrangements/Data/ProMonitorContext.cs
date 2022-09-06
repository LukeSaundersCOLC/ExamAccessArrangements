using ExamAccessArrangements.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupProfileSummary.Data
{
    public partial class ProMonitorContext : DbContext
    {
        public ProMonitorContext(DbContextOptions<ProMonitorContext> options)
            : base(options)
        {
        }
        public virtual DbSet<PMALSInfo> PMALS { get; set; } = null!;
       
    }
}