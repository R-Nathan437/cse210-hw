public class Event
{
    protected string _title;
    public string Title
    {
        get{return _title;}
        set{_title = value;}
    }
    protected string _description;
    public string Description
    {
        get{return _description;}
        set{_description = value;}
    }
    protected string _date;
    public string Date
    {
        get{return _date;}
        set{_date = value;}
    }
    protected string _time;
    public string Time
    {
        get{return _time;}
        set{_time = value;}
    }
    protected Address _address;
    public Address Address
    {
        get{return _address;}
        set{_address = value;}
    }
    protected string _type;
    public string Type
    {
        get{return _type;}
        set{_type = value;}
    }
    protected int _numberAttendees;
    public int NumberAttendees
    {
        get{return _numberAttendees;}
        set{_numberAttendees = value;}
    }

    public Event(string title, string description, string date, string time, Address address, int numberAttendees)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
        NumberAttendees = numberAttendees;
        
    }
    public void DisplayStandard()
    {
        Console.WriteLine($"\n{Title}\n{Description}\n{Date}|{Time}\n\n{Address.FullAddress()}");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"\n{Type}  {Title}\n{Date}");
    }

}