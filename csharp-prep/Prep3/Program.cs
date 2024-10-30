using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        Console.WriteLine(magicNumber);
        
        int number = 0; /// declare here.

        do
        {
            
            Console.Write("What is the magic number? ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number == magicNumber)
            {
                Console.WriteLine("Congrats! You got it write");
            }
            else if (number > magicNumber)
            {
                Console.WriteLine("Gues Lower");
            }
                        else if (number < magicNumber)
            {
                Console.WriteLine("Gues Higher");
            }
            
        }while (number != magicNumber);

        
    }
}