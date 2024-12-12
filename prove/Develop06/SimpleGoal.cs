using System;

public class SimpleGoal : Goals
{
    public bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    // I had to get some help with chatGPT understanding how to return a completed goal.
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Points {_points} Completed {_isComplete}";
    }


}