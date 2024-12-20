class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(int duration, double distance) : base(duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }

    public override int GetPace()
    {
        return (int)(_duration / _distance);
    }
}