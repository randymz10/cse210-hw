using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int option = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            input = Console.ReadLine();
            try
            {
                option = int.Parse(input);
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        System.Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please digit a option above");
            }
        } while (option != 4);


    }
}