public class BreathingActivity : Activity
{
    private string _breatheIn;
    private string _breatheOut;
    public Breathing(string startMessege, string endMessege, string description)
    {
        _startMessege = startMessege;
        _endMessege = endMessege;
        _description = description;
    }
}