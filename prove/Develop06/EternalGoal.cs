class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) {}
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
    public override bool IsComplete()
    {
        return base.IsComplete();

    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

}