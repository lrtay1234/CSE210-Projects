using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your percentage in the class? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);


        if (percentage >= 90)
        {
            Console.WriteLine("You can an A!! ");
            if (percentage > 70)
            {
                Console.WriteLine("You passed the class! ");
            }
        }
        if (percentage < 90 && percentage >= 80)
        {
            Console.WriteLine("You can a B!! ");
            if (percentage > 70)
            {
                Console.WriteLine("You passed the class! ");
            }
        }
        if (percentage < 80 && percentage >= 70)
        {
            Console.WriteLine("You got a C!! ");
            if (percentage > 70)
            {
                Console.WriteLine("You passed the class! ");
            }
        }
        if (percentage < 70 && percentage >= 60)
        {
            Console.WriteLine("You got a D... ");
            if (percentage > 70)
            {
                Console.WriteLine("You passed the class! ");
            }
            else
            {
                Console.WriteLine("You did not pass the Class");
            }
        }

        if (percentage < 60)
        {
            Console.WriteLine("You got a F...");
            if (percentage > 70)
            {
                Console.WriteLine("You passed the class! ");
            }
            else
            {
                Console.WriteLine("You did not pass the Class");
            }

        }

    }
}