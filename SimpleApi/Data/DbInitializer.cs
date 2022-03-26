using Microsoft.EntityFrameworkCore;
using SimpleApi.Entities;
using Task = SimpleApi.Entities.Task;

namespace SimpleApi.Data;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        _modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Admin", Title = "Administrator", Username = "admin", Password = "123456" },
            new User { Id = 2, Name = "David", Title = "Developer" },
            new User { Id = 3, Name = "Lee", Title = "PM" },
            new User { Id = 4, Name = "Tim", Title = "QC" }
            );

        _modelBuilder.Entity<Task>().HasData(
            new Task { Id = 1, Title = "Task 1", Description = "Description 1", State = TaskState.New },
            new Task { Id = 2, Title = "Task 2", Description = "Description 2", State = TaskState.New },
            new Task { Id = 3, Title = "Task 3", Description = "Description 3", State = TaskState.Inprogress },
            new Task { Id = 4, Title = "Task 4", Description = "Description 4", State = TaskState.Inprogress },
            new Task { Id = 5, Title = "Task 5", Description = "Description 5", State = TaskState.Done },
            new Task { Id = 6, Title = "Task 6", Description = "Description 6", State = TaskState.Done }
            );

        _modelBuilder.Entity<Schedule>().HasData(
            new Schedule { Id = 1, Title = "Meeting 1", Description = "Stand up", Location = "Osaka", UserId = 2, Date = DateTime.Now, StartTime = "09:00", EndTime = "11:30" },
            new Schedule { Id = 2, Title = "Meeting 2", Description = "Stand up", Location = "New York", UserId = 2, Date = DateTime.Now.AddDays(5), StartTime = "09:00", EndTime = "11:30" },
            new Schedule { Id = 3, Title = "Meeting 3", Description = "Stand up", Location = "HCM", UserId = 3, Date = DateTime.Now.AddDays(10), StartTime = "09:00", EndTime = "11:30" }
            );
    }
}
