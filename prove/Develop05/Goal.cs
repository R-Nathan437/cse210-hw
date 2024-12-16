using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Transactions;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected string _type;
    protected bool _status;
    protected List<Goal> goals;
    public Goal()
        {
            _title = "";
            _description = "";
            _points = 0;
             _status = false;
        }
    

    public Goal(string title, string description, int points, string type)
    {
        _title = title;
        _description = description;
        _points = points;
        _type = type;
        _status = false;
    }
    public void DisplayPoints()
    {
        Console.WriteLine($"{_points} points\n");
    }
    protected void creatOutline()
    {
        Console.Write.("Goal name: ");
        _title = Console.ReadLine();
        Console.Write.("Goal description:");
        _description = Console.ReadLine();
        Console.Write.("Points: ");
        string stringPoints = (Console.ReadLine());

        if (int.TryParse(stringPoints, out int points))
        {
            _points = points;
        }
        else
        {
            //invaild
        }
        _status = false;
    }
    public void save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal);
            }
        }

    }

    public abstract int GetPoints();
    
    public abstract void RecordGoal();
    
    
}
