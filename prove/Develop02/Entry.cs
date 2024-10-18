class Entry
{
    public string _text;
    public string _prompt = Prompt.gereratePrompt();
    static List<string> getEntry(date, prompt)
    {

        string _text = Console.ReadLine();
        return $"{_date}\n, {prompt}\n, {_text}\n "

    }

}




///Entry
///get prompt
///take user input
/// each entry has a prompt, date and 'entry'