using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assig1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assig1.GetSummary());

        // Now create the derived class assignments
        MathAssignment assig2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assig2.GetSummary());
        Console.WriteLine(assig2.GetHomeworkList());

        WritingAssignment assig3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assig3.GetSummary());
        Console.WriteLine(assig3.GetWritingInformation());
    }
}
// Have a menu system to allow the user to choose an activity.
// Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.
// Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
// Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
// The interface for the program should remain generally true to the one shown in the video demo.
// Provide activities for reflection, breathing, and enumeration, as described below: