using carpoolBG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace carpoolBG.Data
{
    public class CarpoolContext : IdentityDbContext<CarpoolUser, UserRole, string>
    {
        public CarpoolContext(DbContextOptions options) : base(options)
        {
        }

        public CarpoolContext()
        {
            
        }

        public DbSet<CarpoolUser> CarpoolUsers { get; set; }

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

            builder.Entity<Ride>().HasOne(r => r.RideRequest).WithOne(c => c.Ride);
            builder.Entity<Ride>().HasOne(l => l.DropOffLocation).WithOne(r => r.RideDropOff);
            builder.Entity<Ride>().HasOne(l => l.PickUpLocation).WithOne(r => r.RidePickUp);

            builder.Entity<CarpoolUser>().HasMany(r => r.RidesPassenger).WithOne(u => u.Passenger).HasForeignKey(p => p.PassengerId);
            builder.Entity<CarpoolUser>().HasMany(r => r.RidesDriver).WithOne(u => u.Driver).HasForeignKey(p => p.DriverId);

            builder.Entity<CarpoolUser>().HasMany(r => r.ReceivedRatings).WithOne(u => u.ReceivedBy).HasForeignKey(s=>s.ReceivedById);
            builder.Entity<CarpoolUser>().HasMany(r => r.PostedRatings).WithOne(u => u.PostedBy).HasForeignKey(s=>s.PostedById);

            builder.Entity<CarpoolUser>().HasOne(p => p.Preferences).WithOne(u => u.User);
            builder.Entity<CarpoolUser>().HasMany(l => l.SavedLocations).WithOne(p => p.Passenger);

            builder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });
        }
    }
}
