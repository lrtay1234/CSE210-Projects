using System;


// this is the class
class Job
{

    // these are the attributes; _jobTitle and so on
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;



    // this is the Method and i think connected to bahevior
    public void DisplayJobTitles()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

