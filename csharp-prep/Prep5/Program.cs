using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        

        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        // PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNumStr = Console.ReadLine();
            int favNum = int.Parse(favNumStr);
            return favNum;

        }
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;

        }
        // DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int square)
        {
           Console.WriteLine($"{name}, the square of your number is {square}.");

        }
        // Your Main function should then call each of these functions saving the return values and passing data to them as necessary.       
        DisplayWelcome();
        string username = PromptUserName();
        int userNum = PromptUserNumber();
        int SquaredNum =  SquareNumber(userNum);
        DisplayResult(username, SquaredNum);
    }
}