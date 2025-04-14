public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted = 0) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent(GoalManager manager)
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            manager.AddPoints(_points + _bonus);
            Console.WriteLine($"Great job! You earned {_points} points plus {_bonus} bonus points for completing your goal!\n");
            
        }
        else
        {
            manager.AddPoints(_points);
            Console.WriteLine($"Great job working on your goal! You earned {_points} points!\n");
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
        return $"{checkbox} {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_amountCompleted},{_target}";
    }

}