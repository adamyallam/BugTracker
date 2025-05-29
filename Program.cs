using BugTracker.Services;
using BugTracker.Models;

class Program
{
  static void Main()
  {
    BugService service = new BugService();
    Bug newBug = new Bug
    {
      Title = "Syntax Error",
      Description = "You missed ; at line: 10"
    };

    string? action;
    bool isActive = true;

    while (isActive)
    {
      do
      {
        Console.Write("Would you like to: 1 Add a bug, 2 List all bugs, 3 Exit? Enter [1][2][3]:");
        action = Console.ReadLine();

        if (action != "1" && action != "2" && action != "3")
        {
          Console.WriteLine("Only 1, 2, 3 are options!");
        }
      } while (action != "1" && action != "2" && action != "3");

      if (action == "1")
      {
        service.AddBug(newBug);
        Console.WriteLine("New Bug added!");
      }
      else if (action == "2")
      {
        var bugs = service.GetAllBugs();

        for (int i = 0; i < bugs.Count; i++) {
          Console.WriteLine($"Id: {bugs[i].Id}\n Title: {bugs[i].Title} \n Description: {bugs[i].Description} \n Priority: {bugs[i].Priority} \n");
        }
      }
      else if (action == "3")
      {
        return;
      }
    }
  }
}
