public class Running : Activity
{
    private double _distance;
    public double Distance
    {
        get{return _distance;}
        set{_distance = value;}
    }
    public Running(double minutes, double distance) : base(minutes)
    {
        Type = "Running";
        Distance = Math.Round(distance, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(60 / CalculatePace());
    }
    public override double CalculatePace()
    {
        return Math.Round(Minutes/Distance, 2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"\n{Date} {Type} ({Minutes}min): Distance {Distance} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} mins per mile\n");
    }
}