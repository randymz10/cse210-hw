using System.Data;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
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
            Console.WriteLine();
            DisplayPrompt();
            System.Console.WriteLine();
            System.Console.WriteLine("Now ponder on each of the following questions as they reçated to this experince.");
            System.Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now <= endTime)
            {
                DisplayQuestion();
                ShowSpiner(4);
            }
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
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        string input = "";
        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine();
        System.Console.WriteLine($"--- {prompt} ---");
        System.Console.WriteLine();
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input. Please press Enter to continue.");
            input = Console.ReadLine();
        }

    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        System.Console.WriteLine();
        System.Console.WriteLine(question);
    }
}