public abstract class Activity
{
    private string _activityName;
    private string _date;
    private double _durationInMinutes;

    Activity(string date, double minutes)
    {
        _date = date;
        _durationInMinutes = minutes;
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