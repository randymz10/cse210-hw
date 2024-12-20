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
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
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
        int iterator = 1;
        Console.Clear();
        if (_goals.Count == 0)
        {
            System.Console.WriteLine("\nYou still haven't goals.\n");
            return;
        }

        System.Console.WriteLine("The goals are:");
        _goals.ForEach(goal =>
        {
            System.Console.WriteLine($"{iterator}. {goal.ShortName}");
            iterator++;
        });
    }
    public void ListGoalDetails()
    {
        int iterator = 1;
        Console.Clear();
        if (_goals.Count == 0)
        {
            System.Console.WriteLine("\nYou still haven't goals.\n");
            return;
        }

        System.Console.WriteLine("The goals are:");
        _goals.ForEach(goal =>
        {
            System.Console.WriteLine($"{iterator}. {goal.GetDetailsString()}");
            iterator++;
        });
    }
    public void CreateGoal()
    {
        int op = -1;
        bool menuFlag = true;
        string name = "";
        string description = "";
        string points = "";
        int target = -1;
        int bonus = -1;

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
                        System.Console.WriteLine("What is the name of your goal ?");
                        name = Console.ReadLine();
                        System.Console.WriteLine("What is a short description of it? ");
                        description = Console.ReadLine();
                        System.Console.WriteLine("What is the amount of points associated with this goal?");
                        points = Console.ReadLine();
                        SimpleGoal sg = new SimpleGoal(name, description, points);
                        _goals.Add(sg);
                        menuFlag = false;
                        break;
                    case 2:
                        System.Console.WriteLine("What is the name of your goal ?");
                        name = Console.ReadLine();
                        System.Console.WriteLine("What is a short description of it? ");
                        description = Console.ReadLine();
                        System.Console.WriteLine("What is the amount of points associated with this goal?");
                        points = Console.ReadLine();
                        EternalGoal eg = new EternalGoal(name, description, points);
                        _goals.Add(eg);
                        menuFlag = false;
                        break;
                    case 3:
                        System.Console.WriteLine("What is the name of your goal? ");
                        name = Console.ReadLine();
                        System.Console.WriteLine("What is a short description of it? ");
                        description = Console.ReadLine();
                        System.Console.WriteLine("What is the amount of points associated with this goal? ");
                        points = Console.ReadLine();
                        System.Console.WriteLine("How many times does this goal need acomplished for a bonus? ");
                        target = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("What is the bonus for acomplishing it that many times? ");
                        bonus = int.Parse(Console.ReadLine());
                        ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                        _goals.Add(cg);
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
                System.Console.WriteLine();
                Console.WriteLine("Please digit a option above");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
    public void RecordEvent()
    {
        int op = -1;
        ListGoalNames();
        System.Console.WriteLine("Which goal did you accomplish?");
        try
        {
            op = int.Parse(Console.ReadLine());
            if (op > _goals.Count || op < 1)
            {
                System.Console.WriteLine("Please select a valid option");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
            _goals[op - 1].RecordEvent();
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Please select a valid option");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        if (!_goals[op - 1].IsComplete() && _goals[op - 1] is ChecklistGoal cg)
        {
            _score += cg.Bonus;
        }
        else
        {
            _score += _goals[op - 1].Points;
        }
        System.Console.WriteLine($"Congratulations! You have earned {_goals[op - 1].Points} points.");
        System.Console.WriteLine($"Now you have {_score} points.\n");
    }
    public void SaveGoals()
    {
        System.Console.WriteLine("What is the filename of the goal file?");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(_score);
                _goals.ForEach(goal =>
                {
                    sw.WriteLine(goal.GetStringRepresentation());
                });
            }
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Error saving the file");
        }
    }
    public void LoadGoals()
    {
        System.Console.WriteLine("What is the filename of the goal file?");
        string filename = Console.ReadLine();
        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                _score = int.Parse(sr.ReadLine());
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string[] data = parts[1].Split(',');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            SimpleGoal sg = new SimpleGoal(data[0], data[1], data[2]);
                            sg.RecordEvent();
                            _goals.Add(sg);
                            break;
                        case "EternalGoal":
                            EternalGoal eg = new EternalGoal(data[0], data[1], data[2]);
                            eg.RecordEvent();
                            _goals.Add(eg);
                            break;
                        case "ChecklistGoal":
                            ChecklistGoal cg = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[4]), int.Parse(data[3]));
                            cg.RecordEvent();
                            _goals.Add(cg);
                            break;
                    }
                }
            }
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Error loading the file");
        }
    }
}