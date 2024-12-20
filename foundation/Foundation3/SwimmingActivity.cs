class SwimmingActivity : Activity
{
    private int _numOfLaps;

    public SwimmingActivity(int duration, int numOfLaps) : base(duration)
    {
        _numOfLaps = numOfLaps;
    }

    public override double GetDistance()
    {
        return _numOfLaps * 0.05;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _duration * 60;
    }
    public override int GetPace()
    {
        return (int)(_duration / GetDistance());
    }
}