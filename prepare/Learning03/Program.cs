using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction();
        Fraction F3 = new Fraction();
        F1.Numerator = 8;
        F1.Denominator = 3;
        

        F2.Numerator = 8;
        F2.Denominator = 3;
        

        F3.Numerator = 8;
        F3.Denominator = 3;
        

        Console.WriteLine(F1.GetFractionString()); // Output: 1/1
        Console.WriteLine(F2.GetFractionString()); // Output: 6/1
        Console.WriteLine(F3.GetFractionString());
        
        
        

    }
}