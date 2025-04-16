public class CyclingActivity : Activity
{
    private double _speed;

    CyclingActivity(string date, double numberOfMinutes, double speed) : base(date,numberOfMinutes)
    {
        _activityName = "Cycling";
        _speed = speed;
    }
    public override double GetDistance()
    {
        double distance = _speed * _durationInMinutes / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = _durationInMinutes / GetDistance();
        return pace;
    }
}