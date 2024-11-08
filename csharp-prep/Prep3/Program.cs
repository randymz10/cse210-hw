using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1, 101);
        int guess = 0;
        String message = "";

        while (magicNumber != guess)
        {

            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                message = "Higher";
            }
            else if (magicNumber < guess)
            {
                message = "Lower";
            }
            else
            {
                message = "You guessed it!";
            }

            Console.WriteLine(message);
        }
    }
}