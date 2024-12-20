class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(int duration, double speed) : base(duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _duration / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override int GetPace()
    {
        return (int)(60 / _speed);
    }
}