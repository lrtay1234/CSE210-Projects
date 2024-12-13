using System;

public abstract class Activities
{
    protected DateTime _dateTime;
    protected int _minutes;

    public Activities(DateTime dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _dateTime;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetPace();
    public abstract double GetSpeed();

    public virtual string GetString()
    // i did use Ai to know how to format this string. 
    // gettype.name will ge the name of the class
    // :0.0 makes the numebr appear with once decimal
    {
        return @$"{_dateTime:dd MM yyyy} {GetType().Name} ({_minutes} min) - Distance: 
        {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

}