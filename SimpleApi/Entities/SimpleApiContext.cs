using Microsoft.EntityFrameworkCore;
using SimpleApi.Data;

namespace SimpleApi.Entities;

public class SimpleApiContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Schedule> Schedules { get; set; }

    public SimpleApiContext(DbContextOptions<SimpleApiContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
        base.OnModelCreating(modelBuilder);
        ConfigureModelBuilderForUser(modelBuilder);
        ConfigureModelBuilderForTask(modelBuilder);
        ConfigureModelBuilderForSchedule(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }

    void ConfigureModelBuilderForUser(ModelBuilder modelBuilder)
    {
        var builder = modelBuilder.Entity<User>();
        builder.ToTable("User");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Title)
            .HasMaxLength(255)
            .IsRequired();
    }

    void ConfigureModelBuilderForTask(ModelBuilder modelBuilder)
    {
        var builder = modelBuilder.Entity<Task>();
        builder.ToTable("Task");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.State)
            .IsRequired();
    }

    void ConfigureModelBuilderForSchedule(ModelBuilder modelBuilder)
    {
        var builder = modelBuilder.Entity<Schedule>();
        builder.ToTable("Schedule");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(p => p.UserId)
            .IsRequired();

        builder.Property(p => p.Date)
            .IsRequired();
    }
}
