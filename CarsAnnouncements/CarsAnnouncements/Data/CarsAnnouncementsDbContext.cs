using CarsAnnouncements.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsAnnouncements.Data
{
    public class CarsAnnouncementsDbContext : DbContext
    {
        public CarsAnnouncementsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; init; }

        public DbSet<Brand> Brands { get; init; }

        public DbSet<Fuel> Fuels { get; init; }

        public DbSet<Transmission> Transmissions { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .HasForeignKey(c => c.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Car>()
                .HasOne(c => c.Fuel)
                .WithMany(f => f.Cars)
                .HasForeignKey(c => c.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Car>()
                .HasOne(c => c.Transmission)
                .WithMany(t => t.Cars)
                .HasForeignKey(c => c.TransmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
