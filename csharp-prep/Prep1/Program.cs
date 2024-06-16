using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your First Name: ");
        string First = Console.ReadLine();
        Console.Write("What is your Last Name: ");
        string Last = Console.ReadLine();
        Console.WriteLine($"My name is {Last}, {First} {Last}.");

    }
}