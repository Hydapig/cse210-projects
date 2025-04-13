public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent(GoalManager manager)
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            manager.AddPoints(_points + _bonus);
            
        }
        else
        {
            manager.AddPoints(_points);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{IsComplete()},{_name},{_description} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }

}