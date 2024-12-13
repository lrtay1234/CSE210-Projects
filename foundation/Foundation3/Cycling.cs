using System;

public class Cycling : Activities
{
    private double _speed;
    public Cycling(DateTime dateTime, int minutes, double speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }

// I did get some help for AI for the equations. 
    public override double GetDistance()
    {
        return(_speed * GetMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }


}