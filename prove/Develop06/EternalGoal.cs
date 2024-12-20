class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }
    public override void RecordEvent()
    {
        System.Console.WriteLine("\nThis goal don't need to be completed\n");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

}