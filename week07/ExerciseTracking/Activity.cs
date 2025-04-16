public abstract class Activity
{
    public string _activityName { get;set; }
    protected string _date;
    protected double _durationInMinutes;

    public Activity(string date, double numberOfMinutes)
    {
        _date = date;
        _durationInMinutes = numberOfMinutes;
    }

    public void SetActivityName(string name)
    {
        _activityName = name;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_durationInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}