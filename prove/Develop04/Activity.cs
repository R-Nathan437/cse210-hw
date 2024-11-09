public class Activity
{
    public string _startMessege;
    public string _endMessege;
    public int _time;
    public string _description;
    Activity(int item)
    {
      _time = item;
    }

    public void Animation(int time)
    {
      _time = time;
      for (int i = 0; i < _time; i++)
      {
         Console.Write("/");
         Thread.Sleep(250);
         Console.Write("|");
         Thread.Sleep(250);
         Console.Write("\\");
         Thread.Sleep(250);
         Console.Write("-");
         Thread.Sleep(250);
      }
   }
}