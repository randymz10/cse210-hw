class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public int Bonus
    {
        get { return _bonus; }
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            System.Console.WriteLine("\nYou already has completed this goal\n");
            return;
        }
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        };
        return false;
    }
    public override string GetDetailsString()
    {
        string checkbox = "[]";
        if (IsComplete())
        {
            checkbox = "[x]";
        }
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed:{_amountCompleted}/{_target} ";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}