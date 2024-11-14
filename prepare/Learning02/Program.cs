using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Enginer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        job1.Display();
        job2.Display();


        Resume resume = new Resume();

        resume._name = "Allison Rose";
        
        List<Job> jobs = new List<Job>();
        jobs.Add(job1);
        jobs.Add(job2);

        resume._jobs = jobs;
        
        resume.Display();
    }
}