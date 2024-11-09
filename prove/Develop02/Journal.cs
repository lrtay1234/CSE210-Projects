using System;
using System.Collections.Generic;
using System.IO;

class Journal
{

    // this is taking the data in Entry and adding it to the list _entries
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

        // this will make the current date and time (10/31/2024) 
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        // this going intot he promptgenerator class, make it in the variable, and then acts as the behavior (promptGenerator.GetRandomPrompt())
        // then randomText is the varibale for one random prompt
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomText = promptGenerator.GetRandomPrompt();


        // this write out a random text and then entry responses in the tect inputed.
        Console.WriteLine(randomText);
        string entryrespones = Console.ReadLine();


        // this reminds of of C with struct, its a group of date saved under one name
        // it also connects the attributes to the data recieved from the other classes.
        Entry newEntry = new Entry()
        {
            _date = dateText,
            _promptText = randomText,
            _entryResponse = entryrespones
        };

        // this then takes all the data and then adds it to the list _entries.
        _entries.Add(newEntry);

  
    }
    public void DisplayAllEntries()
    {
        // this is what is looks like to breaked each entry in the list of _entries
        foreach (Entry entry in _entries)
        {
            entry.displayJournal();
        }
    }
    public void LoadJournal()
    {
        {
        Console.WriteLine("Enter the filename to load the journal from:");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            Console.WriteLine(Path.GetFullPath(filename));
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    

                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryResponse = parts[2];
                    
                };
            };
            
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


    }
    public void SaveJournal(string filename)
    {


        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryResponse}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }
}