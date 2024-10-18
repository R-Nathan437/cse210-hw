
class Prompt
{

    public string[] _prompts = new string[10] {"What was the best part of today", "2","3","4","5","6","7","8","9","10"};
    
    public string choosePrompt()
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(0, 10);
        return _prompts[answer];   
    }
    
}
    ///Prompt
///generate prompt
///propt list