using System;

public class EternalGoal : Goals
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        return ; // eternal goals are never completed
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}";
    }

    public override string GetDetailsString()
    {
        return $"Eternal Goal {_shortName}: {_description} - Points {_points} (Eternal)";
    }

    }
