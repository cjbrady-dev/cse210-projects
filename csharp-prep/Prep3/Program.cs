using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine($"The magic Number is {magicNumber}");

            Console.Write("What is your guess? ");
            string num = Console.ReadLine();
            int score = int.Parse(num);

            if (score == magicNumber)
            {
                Console.WriteLine("You guessed correctly!");
                response = "You guessed correctly!";
            }
            else
            {
                Console.WriteLine("You guessed incorrectly, sorry!");
                response = "You guessed incorrectly, sorry!";
            }

        } while (response != "You guessed correctly!");
    }
}
