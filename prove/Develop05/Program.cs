using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestManager questManager = new QuestManager();
            questManager.LoadData();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest Program");
                Console.WriteLine("1. Add New Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save and Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        questManager.AddNewGoal();
                        break;
                    case 2:
                        questManager.RecordEvent();
                        break;
                    case 3:
                        questManager.ShowGoals();
                        break;
                    case 4:
                        questManager.ShowScore();
                        break;
                    case 5:
                        questManager.SaveData();
                        return;
                }
            }
        }
    }

    class QuestManager
    {
        private List<Goal> goals = new List<Goal>();
        private int score = 0;

        public void AddNewGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            int choice = int.Parse(Console.ReadLine());

            Goal newGoal = null;
            switch (choice)
            {
                case 1:
                    newGoal = new SimpleGoal();
                    break;
                case 2:
                    newGoal = new EternalGoal();
                    break;
                case 3:
                    newGoal = new ChecklistGoal();
                    break;
            }

            if (newGoal != null)
            {
                newGoal.Initialize();
                goals.Add(newGoal);
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Select Goal to Record Event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetDescription()}");
            }

            int choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice <= goals.Count)
            {
                int points = goals[choice - 1].RecordEvent();
                score += points;
                Console.WriteLine($"Event Recorded. You earned {points} points. Total score: {score}");
            }
        }

        public void ShowGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetStatus());
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Current Score: {score}");
        }

        public void SaveData()
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                writer.WriteLine(score);
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.Serialize());
                }
            }
        }

        public void LoadData()
        {
            if (File.Exists("data.txt"))
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    score = int.Parse(reader.ReadLine());
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Goal goal = Goal.Deserialize(line);
                        if (goal != null)
                        {
                            goals.Add(goal);
                        }
                    }
                }
            }
        }
    }

    abstract class Goal
    {
        protected string description;
        protected int points;

        public abstract void Initialize();
        public abstract int RecordEvent();
        public abstract string GetStatus();
        public abstract string Serialize();

        public static Goal Deserialize(string data)
        {
            string[] parts = data.Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    return new SimpleGoal(parts);
                case "EternalGoal":
                    return new EternalGoal(parts);
                case "ChecklistGoal":
                    return new ChecklistGoal(parts);
                default:
                    return null;
            }
        }

        public string GetDescription()
        {
            return description;
        }
    }

    class SimpleGoal : Goal
    {
        private bool isComplete = false;

        public SimpleGoal() { }

        public SimpleGoal(string[] data)
        {
            description = data[1];
            points = int.Parse(data[2]);
            isComplete = bool.Parse(data[3]);
        }

        public override void Initialize()
        {
            Console.Write("Enter description: ");
            description = Console.ReadLine();
            Console.Write("Enter points: ");
            points = int.Parse(Console.ReadLine());
        }

        public override int RecordEvent()
        {
            if (!isComplete)
            {
                isComplete = true;
                return points;
            }
            return 0;
        }

        public override string GetStatus()
        {
            return $"[Simple Goal] {description} - {(isComplete ? "[X] Completed" : "[ ] Not Completed")}";
        }

        public override string Serialize()
        {
            return $"SimpleGoal|{description}|{points}|{isComplete}";
        }
    }

    class EternalGoal : Goal
    {
        public EternalGoal() { }

        public EternalGoal(string[] data)
        {
            description = data[1];
            points = int.Parse(data[2]);
        }

        public override void Initialize()
        {
            Console.Write("Enter description: ");
            description = Console.ReadLine();
            Console.Write("Enter points: ");
            points = int.Parse(Console.ReadLine());
        }

        public override int RecordEvent()
        {
            return points;
        }

        public override string GetStatus()
        {
            return $"[Eternal Goal] {description} - [+{points} points each time]";
        }

        public override string Serialize()
        {
            return $"EternalGoal|{description}|{points}";
        }
    }

    class ChecklistGoal : Goal
    {
        private int targetCount;
        private int currentCount;
        private int bonusPoints;

        public ChecklistGoal() { }

        public ChecklistGoal(string[] data)
        {
            description = data[1];
            points = int.Parse(data[2]);
            targetCount = int.Parse(data[3]);
            currentCount = int.Parse(data[4]);
            bonusPoints = int.Parse(data[5]);
        }

        public override void Initialize()
        {
            Console.Write("Enter description: ");
            description = Console.ReadLine();
            Console.Write("Enter points: ");
            points = int.Parse(Console.ReadLine());
            Console.Write("Enter target count: ");
            targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            bonusPoints = int.Parse(Console.ReadLine());
        }

        public override int RecordEvent()
        {
            if (currentCount < targetCount)
            {
                currentCount++;
                if (currentCount == targetCount)
                {
                    return points + bonusPoints;
                }
                return points;
            }
            return 0;
        }

        public override string GetStatus()
        {
            return $"[Checklist Goal] {description} - Completed {currentCount}/{targetCount} times";
        }

        public override string Serialize()
        {
            return $"ChecklistGoal|{description}|{points}|{targetCount}|{currentCount}|{bonusPoints}";
        }
    }
}
