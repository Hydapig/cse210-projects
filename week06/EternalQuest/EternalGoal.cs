public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name,description,points){}

    public override void RecordEvent(GoalManager manager)
    {
        manager.AddPoints(_points);
        Console.WriteLine($"Keep up the great work! You earned {_points} points!\n");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_name},{_description},{_points}";
    }
}