namespace SimpleApi.Entities;

public class Task : IEntityBase
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public TaskState State { get; set; }
}
