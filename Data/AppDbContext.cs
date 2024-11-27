using Microsoft.EntityFrameworkCore;
using TechPackManager.Models;

namespace TechPackManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TblMaterial> TblMaterials { get; set; }
        public DbSet<TblType> TblTypes { get; set; }
        public DbSet<TblUnit> TblUnits { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customizing TblType mapping using Fluent API
            modelBuilder.Entity<TblType>()
                .ToTable("tbl_type")  // Specify table name explicitly
                .HasKey(t => t.TypeId);  // Define TypeId as the primary key


            // Customizing TblUnit mapping using Fluent API
            modelBuilder.Entity<TblUnit>()
                .ToTable("tbl_unit")  // Specify table name explicitly
                .HasKey(u => u.UnitId);  // Define UnitId as the primary key


        }
    }
}
