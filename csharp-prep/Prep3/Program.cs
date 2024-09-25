using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
     Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 11);
        int guess = 0;
        int count = 0;
        do
        {
            Console.Write("What's the magic number?");
            guess = int.Parse(Console.ReadLine());
            if (guess < answer)
            {
                count += 1;
                Console.WriteLine("Higher");
            }
            else if (guess > answer)
            {
                count += 1;
                Console.WriteLine("Lower");
            }
            else
            {
                count += 1;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"{count} guesse(s)");
            }
        }
        while (guess != answer);
        
        

        


    }
}