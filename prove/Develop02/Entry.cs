class Entry
{
    static string getPrompt()
    {
        Prompt.generatePrompt();
    }
    static string getEntry()
    {
        string _text = Console.ReadLine();
        Console.WriteLine("Looks good: y");
        Console.WriteLine("Try again: n");
        if (edit = "n")
        {
            string _text = Console.ReadLine();
        }
        else 
        {
            return _text;
        }

    }

}




///Entry
///get prompt
///take user input
/// each entry has a prompt, date and 'entry'