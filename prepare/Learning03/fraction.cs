using System.Globalization;

public class Fraction
{
    private double _topNum;
    private double _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;


    }
    public double Numerator
    {
        get { return _topNum; }
        set {_topNum = value; }
    }
    public double Denominator
    {
        get { return _bottomNum; }
        set { _bottomNum = value; }
    }
    
    public Fraction(double bottom)
    {
        _topNum = 1;
        _bottomNum = bottom;

    }
        public  Fraction(double top, double bottom)
    {
        _topNum = top;
        _bottomNum = bottom;

    }

        public void Display()
{
    Console.WriteLine(GetFractionString());
}
public string GetFractionString()
{
    return $"{_topNum}/{_bottomNum}";
}
public void displayDecimal(double num1)
{
    Console.WriteLine($"{num1}");
}


}