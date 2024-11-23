using System.Diagnostics.Contracts;

public class Simple : Goal
{
    private string _status;
    public Simple(string name, string description, int points, string type) : base(name, description, points, type)
    {
       _status = "Incomplete";
    }
    public override int GetPoints()
    {
        if (_status == "Incomplete")
        {
            return 0;
        }
        else if (_status == "Complete")
        {
            return _points;
        }
        else
        {
            Console.WriteLine("Couldn't determine status");
            return 0;
        }
    }
   




}