class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public Activity() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpiner(5);
        Console.WriteLine();
        Console.WriteLine($"You have complete another {_duration} of the {_name}.");
        ShowSpiner(5);
    }
    public static void ShowSpiner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        while (DateTime.Now <= endTime)
        {
            spinner.ForEach(s =>
            {
                Console.Write(s);
                Thread.Sleep(300);
                Console.Write("\b \b");
            });
        }
    }
    public static void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now <= endTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds.ToString().ToList().ForEach(s => Console.Write("\b \b"));
            seconds--;
        }
    }
}