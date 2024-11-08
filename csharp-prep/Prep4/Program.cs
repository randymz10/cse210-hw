using System;

class Program
{
    static void Main(string[] args)
    {
        int num = -1;
        List<int> numList = new List<int>();
        int maxNum = 0;
        int sum = 0;
        float avg = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {

                numList.Add(num);
            }
        };

        foreach (var number in numList)
        {
            sum += number;

            if (number > maxNum)
            {
                maxNum = number;
            }
        }
        avg = (float)sum / numList.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}