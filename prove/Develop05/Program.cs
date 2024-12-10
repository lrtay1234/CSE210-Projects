using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, Activity> activities = new Dictionary<string, Activity>()
        {
            {"1", new BreathingActivity()},
            {"2", new ListingActivity()},
            {"3", new ReflectingActivity()},
        };
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose your activity:");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. List Activity ");
            Console.WriteLine("3. Reflection Activity ");
            Console.WriteLine("What is your choice? ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }
            // I had some help here with ChatGPT
            // I coudnt figure out how to call the sub classes by selecting which activity I wanted to do
            // I leaded about this conatainkey, and also I had to learn to overide some of the classes.
            else if (activities.ContainsKey(choice))
            {
                activities[choice].Run();

                
            }

            else
            {
                Console.WriteLine("Please try again. ");
            }
        }
    }
}


