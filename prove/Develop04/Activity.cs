public class Activity
{
    protected string _startMessege;
    protected string _endMessege;
    public int _time;
    protected string _description;
    Activity(int time)
    {
      _time = time;
    }

    public void Animation()
    {
       do
      {
         Console.Write("/");
         Console.Clear();
         Console.Write("|");
         Console.Clear();
         Console.Write("\\");
         Console.Clear();
         Console.Write("-");
         Console.Clear();
         _time -= -1;
      }
     while (_time != 0);
      {
        Console.Clear();
      }
   }
}