using System;

public class Fraction
{
    private double _numerator;
    private double _denominator;


    public Fraction(double numerator, double denominator)
    {
        _numerator = numerator;
        _denominator = denominator;

    }
    public double Numerator
    {
        get { return _numerator; }
        set {
            if (_numerator > 0)
                _numerator = value;
            else
                Console.WriteLine("Invalid entry. ");
            }
    }
    
    public double Denominator
    {
        get { return _denominator; }
        set {
            if (_denominator > 0)
                _denominator = value;
            else
                Console.WriteLine("Invalid entry. ");
        
            }
    }
    public void GetFractionString()
    {
        Console.WriteLine($"Your fraction is: {Numerator}/{Denominator} ");
    }

    public void GetDecimalValue()
    {
        double _decimal = Numerator / Denominator;
        Console.WriteLine($"Your Decimal is: {_decimal}");
    }
}