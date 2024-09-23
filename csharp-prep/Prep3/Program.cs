using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
    
        int answer = 18;
        int guess = 0;
        do
        {
            Console.Write("What's the magic number?");
            guess = int.Parse(Console.ReadLine());
            if (guess < answer)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess != answer);
        
        

        


    }
}