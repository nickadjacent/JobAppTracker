using Microsoft.EntityFrameworkCore;

namespace JobAppTracker.Models
{
    public class JobAppTrackerContext : DbContext
    {
        public JobAppTrackerContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}