class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int op = -1;
        while (op != 6)
        {
            Console.Clear();
            DisplayPlayerinfo();
            System.Console.WriteLine();
            System.Console.WriteLine("Menú Options:");
            System.Console.WriteLine(" 1. Create New Goal");
            System.Console.WriteLine(" 2. List Goals");
            System.Console.WriteLine(" 3. Save Goals");
            System.Console.WriteLine(" 4. Load Goals");
            System.Console.WriteLine(" 5. Record Event");
            System.Console.WriteLine(" 6. Quit");
            System.Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            try
            {
                op = int.Parse(input);
                switch (op)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        System.Console.WriteLine("Case 2");
                        break;
                    case 3:
                        System.Console.WriteLine("Case 3");
                        break;
                    case 4:
                        System.Console.WriteLine("Case 4");
                        break;
                    case 5:
                        System.Console.WriteLine("case 5");
                        break;
                    case 6:
                        System.Console.WriteLine("Good bye!");
                        break;
                    default:
                        System.Console.WriteLine();
                        Console.WriteLine("Please select a valid option");
                        System.Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine();
                Console.WriteLine("Please digit a option above");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
    public void DisplayPlayerinfo()
    {
        System.Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        _goals.ForEach(goal =>
        {
            System.Console.WriteLine(goal.ShortName);
        });
    }
    public void ListGoalDetails()
    {
        _goals.ForEach(goal =>
        {
            System.Console.WriteLine(goal.GetDetailsString());
        });
    }
    public void CreateGoal()
    {
        int op = -1;
        bool menuFlag = true;
        while (menuFlag)
        {
            Console.Clear();
            System.Console.WriteLine("The types of Goals are:");
            System.Console.WriteLine(" 1. Simple Goal");
            System.Console.WriteLine(" 2. Eternal Goal");
            System.Console.WriteLine(" 3. Checklist Goal");
            System.Console.WriteLine("Which type of goal would you like to create?");
            string input = Console.ReadLine();
            try
            {
                op = int.Parse(input);
                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("Case 1");
                        menuFlag = false;
                        break;
                    case 2:
                        System.Console.WriteLine("Case 2");
                        menuFlag = false;
                        break;
                    case 3:
                        System.Console.WriteLine("Case 3");
                        menuFlag = false;
                        break;
                    default:
                        System.Console.WriteLine();
                        Console.WriteLine("Please select a valid option");
                        System.Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
    public void RecordEvent() { }
    public void SaveGoals() { }
    public void LoadGoals() { }

}