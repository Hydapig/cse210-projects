public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete=false) : base(name, description,points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent(GoalManager manager)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            manager.AddPoints(_points);
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_points}";
    }
}