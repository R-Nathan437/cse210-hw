using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Transactions;

public abstract class Goal
{
    protected string _title;
    protected string _descirption;
    protected int _points = 0;
    protected string _type;

    public Goal(string title, string description, int points, string type)
    {
        _title = title;
        _descirption = description;
        _points = points;
        _type = type;
    }
    public void DisplayPoints()
    {
        Console.WriteLine($"{_points} points\n");
    }
    public abstract int GetPoints();
    
    public abstract void RecordGoal();
    
    
}
