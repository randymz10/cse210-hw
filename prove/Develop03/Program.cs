using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 3, 5);
        Scripture scripture = new Scripture(reference, "And by the power of the Holy Ghost ye may know the truth of all things.");
        string input = "";

        while (input != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit to finish:");
            input = Console.ReadLine();

            if(scripture.IsCompletelyHidden()){
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
                Console.Clear();
            }
            
            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input. Please press Enter to continue or typee 'quit' to exitt.");
            }

        }
    }
}