using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    // notes for me
    // protected mean that anything from this class can access it, or any inhertied or sub classes can access it.
    // pretty cool ngl :)
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
 

    }
    public virtual void Run()
    {}

    public string Name()
    {
        return _name;
    }

    public string Description()
    {
        return _description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity. ");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration of the activity (seconds). ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("HERE WE GOOOOO!! ");
        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"All Done! You comeplated the {_name}, for {_duration} seconds. ");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        
    }
}