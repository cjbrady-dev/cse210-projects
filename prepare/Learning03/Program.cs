using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction();
        Fraction F3 = new Fraction();
        Fraction F4 = new Fraction();



        F1.Numerator = 1;
        F1.Denominator = 1;
        

        F2.Numerator = 5;
        F2.Denominator = 1;
        

        F3.Numerator = 3;
        F3.Denominator = 4;

        F4.Numerator = 1;
        F4.Denominator = 3;

        double num1 = F1.Numerator/F1.Denominator;
        string rounded1 = $"{num1:0.}";
        
        double num2 = F2.Numerator/F2.Denominator;
        string rounded2 = $"{num2:0.}";

        double num3 = F3.Numerator/F3.Denominator;
        string rounded3 = $"{num3:0.00}";

        double num4 = F4.Numerator/F4.Denominator;
        string rounded4 = $"{num4:0.000000000000000}";

        Console.WriteLine(F1.GetFractionString()); 
        Console.WriteLine($"{rounded1}");
        Console.WriteLine(F2.GetFractionString()); 
        Console.WriteLine($"{rounded2}");
        Console.WriteLine(F3.GetFractionString());
        Console.WriteLine($"{rounded3}");
        Console.WriteLine(F4.GetFractionString());
        Console.WriteLine($"{rounded4}");
        
        
    }
}