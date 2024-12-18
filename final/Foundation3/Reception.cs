public class Reception : Event
{
    private string _userEmail;
    public string UserEmail
    {
        get{return _userEmail;}
        set{_userEmail = value;}
    }
    private string _eventEmail;
    public string EventEmail
    {
        get{return _eventEmail;}
        set{_eventEmail = value;}
    }
   
    public Reception(string title, string description, string date, string time, Address address, int numberAttendees, string eventEmail) : base(title, description, date, time, address, numberAttendees)
    {
        EventEmail = eventEmail;
        NumberAttendees = 0;
        Type = "Reception";
    }
    public void Rsvp()
    {
        Console.WriteLine("Will you be attending?\n Type: Y for yes || Type: N for no");
        string response = Console.ReadLine().ToLower();
        bool running = true;
        while (running)
        {
            if (response == "y")
            {
                Console.WriteLine("What is your email:");
                UserEmail = Console.ReadLine();
                Console.WriteLine("Thank you for your RSVP");
                NumberAttendees++;
                running = false;
            }
            else if (response == "n")
            {
                Console.WriteLine("Thank you for your RSVP");
                running = false;
            }
            else
            {
                Console.WriteLine("invalid input. Please type 'Y' or 'N'.");
            }
        }
    }
    public void DisplayReception()
    {
         Console.WriteLine($"{Title}\n{Description}\n{Date}|{Time}\n\n{Address.FullAddress()}\n{EventEmail} || {NumberAttendees}: RSVP'S\n");
    }
}