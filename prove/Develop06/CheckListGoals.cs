using System;

public class CheckListGoals : Goals
{
    // so i had this private, and on my managegoals, I had an error on line 211
    // i looked up the issue, they said I had to change it to protected,
    // it still didn't work so i changed it to public then worked.
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoals(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

   public override void RecordEvent() // this will continue to record until goal is reached
    {
        if (_amountCompleted < _target)
        {// this took me a minute but the ++ just adds 1 to the amount
            _amountCompleted++;
        }
    }

    public override bool IsComplete()// this marks once goal is complete or return true
    {
        // once this is = or > it will return false
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $@"{_shortName}: {_description} - Points {_points}, 
        completed(amount completed/target): {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoals|{_shortName}|{_shortName}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}