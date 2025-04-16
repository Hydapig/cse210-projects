public abstract class Activity
{
    public string _activityName { get;set; }
    protected DateTime _date;
    protected double _durationInMinutes;

    public Activity(DateTime date, double numberOfMinutes)
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
        return $"{_date.ToString("dd MMM yyyy")} {_activityName} ({_durationInMinutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}