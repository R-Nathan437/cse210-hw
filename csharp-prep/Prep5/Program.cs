using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int square = SquareNumber(userNum);
        DisplayResult(userName, square);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What's your name?: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What's your favorite number?");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }
        static int SquareNumber(int number)
        {
           int numberSquared = number * number;
            return numberSquared;
        }
        static void DisplayResult(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, your number squared is {numberSquared}");
        }
}