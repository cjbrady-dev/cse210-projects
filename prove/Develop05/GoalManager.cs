using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    public List<Goal> Goals { get; private set; }
    public int TotalPoints { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName)
            {
                TotalPoints += goal.RecordEvent();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine($"Total Points: {TotalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(TotalPoints);
            foreach (var goal in Goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    outputFile.WriteLine($"SimpleGoal:{simpleGoal.Name},{simpleGoal.Description},{simpleGoal.Points},{simpleGoal.IsCompleted}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal:{eternalGoal.Name},{eternalGoal.Description},{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"ChecklistGoal:{checklistGoal.Name},{checklistGoal.Description},{checklistGoal.Points},{checklistGoal.TargetCount},{checklistGoal.CurrentCount},{checklistGoal.BonusPoints}");
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            TotalPoints = int.Parse(lines[0]);
            Goals.Clear();
            foreach (var line in lines.Skip(1))
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] details = parts[1].Split(',');

                if (type == "SimpleGoal")
                {
                    var goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]))
                    {
                        IsCompleted = bool.Parse(details[3])
                    };
                    Goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    var goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                    Goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    var goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[5]))
                    {
                        CurrentCount = int.Parse(details[4])
                    };
                    Goals.Add(goal);
                }
            }
        }
    }
}
