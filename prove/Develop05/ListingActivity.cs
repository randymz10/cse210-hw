class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            ];
    }
    public void Run()
    {
        DisplayStartingMessage();
        try
        {
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpiner(4);
            System.Console.WriteLine();
            System.Console.WriteLine("List as many responses you can to the following prompt:");
            GetRandomPrompt();
            System.Console.Write("You may begin in: ");
            ShowCountDown(5);
            System.Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            List<string> userList = GetListFromUser();
            while (DateTime.Now <= endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                userList.Add(input);
            }

            _count = userList.Count;
            System.Console.WriteLine($"You listed {_count} items!");
            DisplayEndingMessage();

        }
        catch (System.Exception)
        {
            System.Console.WriteLine();
            Console.WriteLine("Please, insert a valid number");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Run();
        }
    }
    void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"--- {randomPrompt} ---");
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = [];
        return userList;
    }
}