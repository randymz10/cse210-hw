using System;

// Was added error typing management and functionalities to clean a wait the console in each actions.
class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        string filename = "";
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");

        do
        {
            Console.WriteLine("Please select one of the folloing choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                option = 0;
            }

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    newEntry._entryText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    CleanConsole();
                    break;
                case 2:
                    Console.Clear();
                    journal.DisplayAll();
                    CleanConsole();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("What is the filename?");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    CleanConsole();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("What is the filename?");
                    filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    CleanConsole();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong option");
                    CleanConsole();
                    break;
            }


        } while (option != 5);
    }

    static void CleanConsole()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}