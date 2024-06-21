using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _listJob = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Job History:");
        foreach (var job in _listJob)
        {
            job.Display();
        }
    }
}
