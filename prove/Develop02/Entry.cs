using System;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryResponse;

    public void displayJournal()
    {
            Console.WriteLine($"{_date} - {_promptText} \n{_entryResponse}" );
    }
}