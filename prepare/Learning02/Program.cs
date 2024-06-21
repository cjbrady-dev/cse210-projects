using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Create and initialize job1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2020;

        // Create and initialize job2
        Job job2 = new Job();
        job2._company = "Conservice";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2020;
        job2._endYear = 2021;

        // Create and initialize resume
        Resume resume1 = new Resume();
        resume1._name = "James Brady";

        // Add jobs to the resume
        resume1._listJob.Add(job1);
        resume1._listJob.Add(job2);

        // Display the resume (name and job history)
        resume1.Display();
    }
}
