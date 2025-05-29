namespace BugTracker.Models
{
  public enum Priority
  {
    Low,
    Medium,
    High
  }

  public class Bug
  {
    public int Id { get; private set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsResolved { get; set; }

    public Bug()
    {
      CreatedAt = DateTime.UtcNow;
      IsResolved = false;
    }

    public void SetId(int id)
    {
      Id = id;
    }
  }
}