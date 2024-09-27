using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;
        Console.WriteLine("Enter a number (0 to quit):");
        while(newNumber != 0)
        
            {
                Console.Write("Enter a number:");
                newNumber = int.Parse(Console.ReadLine());
                if(newNumber != 0)
                {
                    numbers.Add(newNumber);
                }
            }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[^1];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}