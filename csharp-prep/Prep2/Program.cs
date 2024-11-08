using System;

class Program
{
    static void Main(string[] args)
    {
        int percentage = 0;
        String grade = "";

        Console.WriteLine("What is your grade percentage?");
        percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percentage > 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You need to make more effort");
        }
    }
}