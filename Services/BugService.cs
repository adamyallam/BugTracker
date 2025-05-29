using BugTracker.Models;

namespace BugTracker.Services
{
  public class BugService
  {
    private List<Bug> _bugs = new();
    private int _nextId = 1;

    public void AddBug(Bug newBug)
    {
      newBug.SetId(_nextId++);
      _bugs.Add(newBug);
    }

    public List<Bug> GetAllBugs()
    {
      return _bugs;
    }

    public Bug? GetBug(int id)
    {
      return _bugs.FirstOrDefault(b => b.Id == id);
    }
  }
}