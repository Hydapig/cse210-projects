public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, double numberOfMinutes, double distance) : base(date,numberOfMinutes)
    {
        _activityName = "Running";
        _distance = distance;
    }

    
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _durationInMinutes) * 60;
    }
    public override double GetPace()
    {
        return _durationInMinutes / _distance;
    }
}