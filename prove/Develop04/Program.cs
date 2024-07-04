using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfulness.");
        
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Please choose one of the following items:");
            Console.WriteLine("1. Display the journal");
            Console.WriteLine("2. Save the journal to a file");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

        switch (choice)
            {
                case "1":
                    Console.Write("Start breathing activity: ");
                    string response = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Start reflecting activity: ");
                    break;
                case "3":
                    Console.Write("Start listing activity: ");
                    string saveFilename = Console.ReadLine();
                    break;
                case "4":
                       exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
    }
}
}

// Have a menu system to allow the user to choose an activity.
// Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
// Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
// Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
// The interface for the program should remain generally true to the one shown in the video demo.
// Provide activities for reflection, breathing, and enumeration, as described below: