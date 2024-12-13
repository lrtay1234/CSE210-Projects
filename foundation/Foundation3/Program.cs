using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activities> activities = new List<Activities>()
        {               // i did have to use Ai to place the datetime and how it supposed to be inputed here.
            new Running(new DateTime(2024, 5, 3), 20, 4),
            new Cycling(new DateTime(2024, 5, 3), 40, 4),
            new Swimming(new DateTime(2024, 5, 3), 25, 4),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetString());
            Console.WriteLine();
        }
    }
}