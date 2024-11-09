using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int maxNumber = 0;




        while (number != 0)
        {

            Console.WriteLine("Enter in numbers (O to quit): ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
            numbers.Add(number);
            }
            
            
        }

        foreach (int number2 in numbers)
        {
            sum += number2;
        }
        Console.WriteLine($"The sum is {sum}");

        double ave = (double)sum / numbers.Count;

        Console.WriteLine($"The average is {ave}. ");

        foreach (int number3 in numbers)
        {
            if (number3 > maxNumber)
            {
                maxNumber = number3;
            }
        
        }
        Console.WriteLine($"The max number is {maxNumber}. ");

    }
}