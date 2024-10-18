using System.IO;
using System.Security.Cryptography.X509Certificates;
class Journal
{
    public string _entry;
    static string addEntry()
    {
       

    }
    static void display()
    {

    }
    static void save()
    {
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entry);
        }

    }
    static void load()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
        }
    }
}

////Journal
///add entry method
///display method
///save method
///load method
///menu <list>