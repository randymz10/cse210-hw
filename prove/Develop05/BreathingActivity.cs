class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        try
        {
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready");
            ShowSpiner(4);
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now <= endTime)
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                ShowCountDown(6);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
        catch (System.Exception)
        {
            System.Console.WriteLine();
            Console.WriteLine("Please, insert a valid number");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}