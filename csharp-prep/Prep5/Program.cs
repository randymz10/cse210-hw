using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static String PromptUserName()
        {
            Console.Write("Please enter your name: ");
            String userName = Console.ReadLine();

            return userName;
        }

        static int UserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;
        }

        static int SquareNumber(int num)
        {
            return (int)Math.Pow(num, 2);
        }

        static void DisplayResult(string userName, int num)
        {
            Console.WriteLine($"{userName}, the square of your number is {num}");
        }


        DisplayWelcome();
        String userName = PromptUserName();
        int num = UserNumber();
        int squareNumber = SquareNumber(num);
        DisplayResult(userName, squareNumber);
    }
}