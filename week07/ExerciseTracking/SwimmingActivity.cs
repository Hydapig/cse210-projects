public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    SwimmingActivity(string date, double numberOfMinutes, int numberOfLaps) : base(date,numberOfMinutes)
    {
        _activityName = "Swimming";
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / _durationInMinutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = _durationInMinutes / GetDistance();
        return pace;
    }
}