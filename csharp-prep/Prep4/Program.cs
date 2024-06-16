using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int newNum;

        do
        {
            Console.Write("Add a new number to the list (enter 0 to finish): ");
            string num = Console.ReadLine();

            // Convert input to integer
            if (!int.TryParse(num, out newNum))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Skip the rest of the loop and start over
            }

            if (newNum != 0)
            {
                numbers.Add(newNum);
            }

        } while (newNum != 0);

        // Print the numbers in the list
        Console.WriteLine("Numbers in the list:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Compute the sum of the numbers
        int sum = numbers.Sum();

        // Compute the average of the numbers (if the list is not empty)
        double average = numbers.Count > 0 ? numbers.Average() : 0;

        // Find the maximum number in the list (if the list is not empty)
        int maxNumber = numbers.Count > 0 ? numbers.Max() : 0;

        // Output results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {maxNumber}");

    }
}
