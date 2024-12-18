public class Biking : Activity
{
    private double _speed;
    public double Speed
    {
        get{return _speed;}
        set{_speed = value;}
    }
    public Biking(double minutes, double speed) : base(minutes)
    {
        Type = "Biking";
        Speed = Math.Round(speed, 2);
    }

    public override double CalculateDistance()
    {
        return Math.Round((Speed * 60) / Minutes, 2);
    }
    public override double CalculatePace()
    {
        return Math.Round(60 / Speed, 2);
    }
    public override void GetSummary()
    {
        Console.WriteLine($"\n{Date} {Type}({Minutes}min): Distance {CalculateDistance()} miles, Speed {Speed} mph, Pace {CalculatePace()} mins per mile\n");
    }
}