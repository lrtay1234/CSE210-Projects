using System;



// this is the class
class Program
{
    static void Main(string[] args)
    {

        // job1 is the object
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        // job2 is the objects
        Job job2 = new Job();

        job2._jobTitle = "Eletrical engineer";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2022;


        // this will display the jobs
        // job1.DisplayJobTitles();
        // job2.DisplayJobTitles();

        Resume resume= new Resume();

        resume._firstName = "Landon";
        resume._lastName = "Taylor";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayEverything();


        // this is the code that will go into the resumes, find the job in the list set at 0 and then post the job title
        // you can change it to see the next job in the list, or what year he started, or company.
        // Console.WriteLine($"First job title: {resume._jobs[0]._jobTitle}");
     
    }
}