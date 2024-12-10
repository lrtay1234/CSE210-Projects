using System;

public class ListingActivity : Activity
{

     private List<string> prompts = new List<string>()
     {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _count;
    private List<string> _list;
     

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _list = new List<string>();
    }


    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(6);
        GetListFromUser();
        Console.WriteLine($"You have {_count} items. ");
        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {

        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
        
    }

    public void GetListFromUser()
    {
        DateTime startTime= DateTime.Now;
        // I got some help from Chat GPT
        // here it takes the date a time now the subtracts from the inital datetime, and the
        // .totalseconds converts it to seconds
        // once datetime is bigger than duration it will stop the loop
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Enter Information: ");
            string item = Console.ReadLine();
            _list.Add(item);
        }
        _count = _list.Count;
    }
}