public class Outdoor : Event
{
    private string _weather;
    public string Weather
    {
        get{return _weather;}
        set{_weather = value;}
    }
    public Outdoor(string title, string description, string date, string time, Address address, int numnberAttendees, string weather) : base(title, description, date, time, address, numnberAttendees)
    {
        Weather = weather;
        Type = "Outdor";
    }
    public void DisplayOutdoor()
    {
        Console.WriteLine($"{Title}\n{Description}\n{Date}|{Time}\n||{Weather}||\n\n{Address.FullAddress()}\n");
    }
}