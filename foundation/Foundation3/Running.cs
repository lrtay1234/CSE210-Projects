using System;

public class Running : Activities
{
    private double _distance;

    public Running(DateTime dateTime, int minutes, double distance) : base(dateTime, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }


}