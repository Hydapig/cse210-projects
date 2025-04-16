public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    public SwimmingActivity(DateTime date, double numberOfMinutes, int numberOfLaps) : base(date,numberOfMinutes)
    {
        _activityName = "Swimming";
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _durationInMinutes) * 60;
    }
    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }
}