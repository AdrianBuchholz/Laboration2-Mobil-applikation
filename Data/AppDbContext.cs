using Microsoft.EntityFrameworkCore;
using MobilApplikation_Grupp_3.Models;

namespace MobilApplikation_Grupp_3.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Concert> Concerts { get; set; } = null!;
        public DbSet<Performance> Performances { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
}
