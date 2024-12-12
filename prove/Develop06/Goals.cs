using System;

// i feel like this one was pretty self explainitoy in the assignment
public abstract class Goals
{
    protected string _shortName;
    protected string _description;
    public int _points;

    public Goals(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation(); 
}