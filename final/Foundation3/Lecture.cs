public class Lecture : Event
{
    private string _speaker;
    public string Speaker
    {
        get{return _speaker;}
        set{_speaker = value;}
    }
    private int _capacity;
    public int Capacity
    {
        get{return _capacity;}
        set{_capacity = value;}
    }
    public Lecture(string title, string description, string date, string time, Address address, int numberAttendees, int capacity, string speaker) : base(title, description, date, time, address, numberAttendees)
    {
        Capacity = capacity;
        Speaker = speaker;
        Type = "Lecture";
    }
    public void DisplayLecture()
    {
        Console.WriteLine($"{Title} | {Speaker}\n{Description}\n{Date}|{Time}\n\n{Address.FullAddress()}\n\n {NumberAttendees}/{Capacity} Capacity");
    }
}