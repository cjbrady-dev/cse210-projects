using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is the score: ");
        string num = Console.ReadLine();
        int score = int.Parse(num);
        if (score > 90)
        {
            string letter = ("Grade A+");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 90)
        {
            string letter = ("Grade A-");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 85 && score < 90)
        {  
            string letter = ("Grade B+");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 80 && score < 85)
        {  
            string letter = ("Grade B-");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 75 && score < 80)
        {  
            string letter = ("Grade C+");
            Console.WriteLine($"{letter}"); 
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 70 && score < 75)
        {  
            string letter = ("Grade C-");
            Console.WriteLine($"{letter}"); 
            Console.WriteLine("Congrats you passed!");
        }
        else if (score >= 65 && score < 70)
        {  
            string letter = ("Grade D+");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Sorry you did not pass please try again!"); 
        }
        else if (score >= 60 && score < 65)
        {  
            string letter = ("Grade D-");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Sorry you did not pass please try again!"); 
        }
        else if (score < 60)
        {  
            string letter = ("Grade F");
            Console.WriteLine($"{letter}");
            Console.WriteLine("Sorry you did not pass please try again!"); 
        }
    }
}