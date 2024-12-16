public class Entry
{
    public string _prompt;
    public string _date;
    public string _text;
    List<string> _prompts = new List<string>()
        {
            ""
        };
    public void GeneratePrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count());
        _prompt = _prompts[randomIndex];
        Console.WriteLine($"Prompt: {_prompt}");
    }
    public void GenerateDate()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }
    public void GetText()
    {
        Console.Write("   ");
        _text = Console.ReadLine();
    }
}




///Entry
///get prompt
///take user input
/// each entry has a prompt, date and 'entry'