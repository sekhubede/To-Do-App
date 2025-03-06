namespace API.Entities;
public class Task
{
    public int Id { get; set; }
    public required string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    public DateTime? CompleteDate { get; set; }
}