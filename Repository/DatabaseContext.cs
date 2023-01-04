using Microsoft.EntityFrameworkCore;
using Repository.Model;

namespace Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<HelthCheckPollEntity> HealthCheck { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelthCheckPollEntity>().ToTable("HelthCheckPoll");
        }

    }
}
