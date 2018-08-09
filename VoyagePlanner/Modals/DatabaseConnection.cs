using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Configuration;
using Microsoft.Extensions.Options;

namespace VoyagePlanner
{
    public partial class DatabaseConnection : DbContext
    {
        
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {
            
        }
        public virtual DbSet<VoyagePlanTemplateDetail> VoyagePlanTemplateDetails { get; set; }
        public virtual DbSet<VoyagePlan> VoyagePlan { get; set; }
        public virtual DbSet<VoyagePlanDetail> VoyagePlanDetail { get; set; }
        public virtual DbSet<VoyagePlanTemplate> VoyagePlanTemplate { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<PathLocation> PathLocation { get; set; }
        public virtual DbSet<Path> Path { get; set; }

    }

}
