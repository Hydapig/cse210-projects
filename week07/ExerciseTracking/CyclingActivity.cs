public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, double numberOfMinutes, double speed) : base(date,numberOfMinutes)
    {
        _activityName = "Cycling";
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _durationInMinutes / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}