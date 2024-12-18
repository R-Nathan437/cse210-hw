public class Swimming : Activity
{
    private int _numberOfLaps;
    public int NumberOfLaps
    {
        get{return _numberOfLaps;}
        set{_numberOfLaps = value;}
    }
    public Swimming(double minutes, int numberOfLaps) : base(minutes)
    {
        Type = "Swimming";
        NumberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return Math.Round((NumberOfLaps * 50 )/ (1000  * 0.62), 2);
    }
    public override double CalculateSpeed()
    {
        return Math.Round(60 / CalculatePace(), 2);
    }
    public override double CalculatePace()
    {
        return Math.Round(Minutes/CalculateDistance(), 2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"\n{Date} {Type}({Minutes}min): Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} mins per mile\n");
    }
}