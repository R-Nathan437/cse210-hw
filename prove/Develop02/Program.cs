using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        // public string response = "";
        // while (response != "q")
        // {
        //     Console.WriteLine("Add Entry: press A");
        //     Console.WriteLine("Save Entry: press S");
        //     Console.WriteLine("Load Entry: press L");
        //     Console.WriteLine("Quit: Q");
        //     if (response = "A")
        //     {
        //         public string _new entry Journal.addEntry();
        //     }
        string test = Prompt.selectPrompt();
        Console.WriteLine(test);
    }
 }



///display menu loop
///add to journal
///quit