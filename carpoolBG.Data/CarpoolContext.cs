using carpoolBG.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace carpoolBG.Data
{
    public class CarpoolContext : IdentityDbContext
    {
        public CarpoolContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Ride> Rides { get; set; }

        public DbSet<RideRequest> RideRequests { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Preferences> Preferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
