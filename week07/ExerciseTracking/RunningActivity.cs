public class RunningActivity : Activity
{
    private double _distance;

    RunningActivity(string date, double numberOfMinutes, double distance) : base(date,numberOfMinutes)
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
        double speed = (_distance / _durationInMinutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _durationInMinutes / _distance;
        return pace;
    }
}