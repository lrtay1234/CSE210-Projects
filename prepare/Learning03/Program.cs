using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter in the Numerator: ");
        string input = Console.ReadLine();
        int numerator = int.Parse(input);
        Console.WriteLine("Enter in the Denominator: ");
        string input2 = Console.ReadLine();
        int denominator = int.Parse(input2);

        Fraction f = new Fraction(numerator, denominator);



        f.GetFractionString();
        f.GetDecimalValue();


    }
}