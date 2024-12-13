using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int option = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            try
            {
                option = int.Parse(input);
                switch (option)
                {
                    case 1:
                        BreathingActivity ba = new BreathingActivity();
                        ba.Run();
                        break;
                    case 2:
                        ReflectingActivity re = new ReflectingActivity();
                        re.Run();
                        break;
                    case 3:
                        ListingActivity la = new ListingActivity();
                        la.Run();
                        break;
                    case 4:
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
        } while (option != 4);


    }
}