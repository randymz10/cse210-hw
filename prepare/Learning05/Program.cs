using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment asgnmt = new MathAssignment("Section 7.3", "Problems 8-19","Samuel Bennett", "Multiplication");
        Console.WriteLine(asgnmt.GetSummary());
        Console.WriteLine(asgnmt.GetHomeWorkList());

        WritingAssignment writingAsgnmt = new WritingAssignment("The Causes of World War II","Mary Waters", "European History");
        Console.WriteLine(writingAsgnmt.GetSummary());
        Console.WriteLine(writingAsgnmt.GetWritingInformation());
    }
}