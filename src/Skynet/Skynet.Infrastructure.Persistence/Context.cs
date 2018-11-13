using Microsoft.EntityFrameworkCore;
using Skynet.Domain;
using Skynet.Infrastructure.Persistence.Data;

namespace Skynet.Infrastructure.Persistence
{
    public class Context : DbContext
    {
        public DbSet<Robot> Robots { get; set; }
        public DbSet<Capture> Captures { get; set; }
        
        public Context()
        {
            
        }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Robots

            modelBuilder.Entity<Robot>().ToTable("Robots", "Skynet");

            modelBuilder.Entity<Robot>().HasKey(x => x.Id);

            modelBuilder.Entity<Robot>()
                .HasMany(x => x.Captures)
                .WithOne(x => x.Robot)
                .HasForeignKey(x => x.RobotId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Robot>().HasData(RobotRepository.Get());

            // Captures

            modelBuilder.Entity<Capture>().ToTable("Captures", "Skynet");

            modelBuilder.Entity<Capture>().HasKey(x => x.Id);
        }
    }
}
