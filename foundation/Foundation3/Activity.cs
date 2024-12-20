abstract class Activity
{
    protected DateTime _date;
    protected int _duration;

    public Activity(int duration)
    {
        _date = DateTime.Now;
        _duration = duration;
    }
    public int Duration
    {
        get { return _duration; }
    }
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running({_duration} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract int GetPace();

}