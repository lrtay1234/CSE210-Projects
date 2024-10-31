using System;
using System.Collections.Generic;

// this is the class
class Resume
{
    public string _firstName;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();


    public void DisplayEverything()
    {

        Console.WriteLine($"Name: {_firstName} {_lastName}");
    {
        foreach (Job job in _jobs)
        {
            job.DisplayJobTitles();
        }

    }
    }
}

