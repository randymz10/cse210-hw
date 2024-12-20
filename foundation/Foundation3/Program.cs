using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[3];
        activities[0] = new RunningActivity(30, 5);
        activities[1] = new RunningActivity(45, 7);
        activities[2] = new CyclingActivity(60, 15);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}