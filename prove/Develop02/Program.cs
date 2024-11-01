using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal= new Journal();
        int choice = 0;

        Console.WriteLine("Welcome to the journal. Here are your options. ");



        do
        {
            Console.WriteLine("1. Add Entry. ");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Select your option: ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);


            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {
                journal.DisplayAllEntries();
            }
            else if (choice == 3)
            {
                journal.LoadJournal();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to save the journal to:");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);
            }
        } while (choice != 0);

        

    }
}


