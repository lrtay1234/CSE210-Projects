using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string userinput = "no";
        Reference reference = new Reference("Proverbs", 3, 5);
        string scriptureText = "Trust in the Lord with all thine heart, and lean not unto thine own understanding";

        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Here is your scripture, Good Luck!!");
        Console.WriteLine(scripture.GetDisplay());
        Console.ReadLine(); 
        while (scripture.IsCompletetelyHidden() != true && userinput != "yes")
        {
            scripture.HideRandomWords();

            Console.Clear();
            Console.WriteLine("\nScripture with Hidden Words:");
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine("Would you like to quit?");
            userinput = Console.ReadLine();
        }

    }
 }