public class Verse
{
    private Scripture _scripture;
    private List<string> _scriptureList;  
    private int _allWordsRemoved = 0;
    public Verse(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureList = new List<string>();
        convertToList();
    }
    private void convertToList()
    {
        _scriptureList = _scripture.convertToString().Split(" ").ToList();
    }
    public void removeWords()
    {
        int numberToRemove = 3;
        int _wordsRemoved = 0;

        do
        {
            int randomI = new Random().Next(0, _scriptureList.Count());
            if(_scriptureList[randomI].Contains('_') == false)
            {
                _scriptureList[randomI] = new string('_', _scriptureList[randomI].Length);
                _wordsRemoved++;
                _allWordsRemoved++;
                if ((_scriptureList.Count() - numberToRemove) <= _allWordsRemoved && _allWordsRemoved < (_scriptureList.Count() + 1))
                {
                    _wordsRemoved = 3;
                }
            }
         }
        while (_wordsRemoved != numberToRemove);
    }
    public string convertToString()
    {
        return string.Join(" ", _scriptureList);
    }
    public bool hasWordsLeft()
    {
        bool returnValue = false;
        foreach (string word in _scriptureList)
        {
            if (word.Contains("_") == false)
            {
                returnValue = true;
                break;
            }
            else
            {
                returnValue = false;
            }
        }
        return returnValue;
    }

}