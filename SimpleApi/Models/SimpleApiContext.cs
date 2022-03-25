using Microsoft.EntityFrameworkCore;

namespace SimpleApi.Models
{
    public class SimpleApiContext: DbContext
    {
        public SimpleApiContext(DbContextOptions<SimpleApiContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; } 
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Task>().ToTable("Task");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
        }
    }
}
