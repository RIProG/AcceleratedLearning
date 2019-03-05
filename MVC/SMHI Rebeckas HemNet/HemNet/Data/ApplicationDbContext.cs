using HemNet.Models;
using HemNet_Azure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HemNet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<HousingCooperative> HousingCooperatives { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string columnType = "decimal(18,2)";
            builder.Entity<Apartment>().Property(p => p.Price).HasColumnType(columnType);
            builder.Entity<Apartment>().Property(p => p.Rent).HasColumnType(columnType);
            builder.Entity<Apartment>().Property(p => p.Size).HasColumnType(columnType);
            builder.Entity<Apartment>().Property(p => p.Rooms).HasColumnType(columnType);
            builder.Entity<Apartment>().Property(p => p.OperatingCost).HasColumnType(columnType);
            base.OnModelCreating(builder);
        }
    }
}
