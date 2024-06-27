using System.Globalization;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;


    }
    public int Numerator
    {
        get { return _topNum; }
        set {_topNum = value; }
    }
    public int Denominator
    {
        get { return _bottomNum; }
        set { _bottomNum = value; }
    }
    
    public Fraction(int bottom)
    {
        _topNum = 1;
        _bottomNum = bottom;

    }
        public  Fraction(int top, int bottom)
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
public void Display()
{
    Console.WriteLine(GetFractionString());
}




}