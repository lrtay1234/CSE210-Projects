using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResults();



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program. ");
        }

        static string EnterName()
        {

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;

        }

        static int PromptNumber()
        {
            Console.WriteLine("What is your favoite number? ");
            string userInput = Console.ReadLine();
            int favNumber = int.Parse(userInput);
            return favNumber;
        }


        static int SquareNumber()
        {
            int number = PromptNumber();
            int square = number * number;
            return square;
            
        }

        static void DisplayResults()
        {
            string name = EnterName();
            int squaredNumber = SquareNumber();

            Console.WriteLine($"Your name is {name}, and your favorite number squared is {squaredNumber}. ");
        }





        




        
    }
}