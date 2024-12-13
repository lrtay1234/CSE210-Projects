using System;

public class Swimming : Activities
{
    private double _laps;
    public Swimming(DateTime dateTime, int minutes, double laps) : base(dateTime, minutes)
    {
        _laps = laps;
    }

// I did get some help for AI for the equations. 
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }


}