using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string input = Console.WriteLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("Start breathing activity...");
                break;
                case "2":
                    Console.WriteLine("Start reflecting activity...");
                break;
                case "3":
                    Console.WriteLine("Start listing activity...");
                break;
                case "4":
                    Console.WriteLine("Exiting...");
                break;
                default:
                    Console.WriteLine("Invalid entry, please try again.");
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