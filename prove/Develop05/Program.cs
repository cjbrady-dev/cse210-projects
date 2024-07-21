using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter goal type (1- Simple, 2- Eternal, 3- Checklist):");
                int goalType = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter goal name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter goal description:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter goal points:");
                int points = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    manager.AddGoal(new SimpleGoal(name, description, points));
                }
                else if (goalType == 2)
                {
                    manager.AddGoal(new EternalGoal(name, description, points));
                }
                else if (goalType == 3)
                {
                    Console.WriteLine("Enter target count:");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bonus points:");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter goal name to record event:");
                string name = Console.ReadLine();
                manager.RecordEvent(name);
            }
            else if (choice == 3)
            {
                manager.DisplayGoals();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter filename to save goals:");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Enter filename to load goals:");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if (choice == 6)
            {
                break;
            }
        }
    }
}
