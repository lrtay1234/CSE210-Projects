using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Summary a1 = new Summary("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.getSummary());

        // Now create the derived class assignments
        MathAssignments a2 = new MathAssignments("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.getSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.getSummary());
        Console.WriteLine(a3.Title());
        

    }
}