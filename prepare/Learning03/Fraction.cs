using System;

public class Fraction
{

    private int _numerator;
    private int _denominator;


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int denominator) //this is different then outlined in the instructions, but I think 1/x is more useful than x/1 as x over 1 is always the number passed to it
    {
        _numerator = 1;
        _denominator = denominator;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void Display()
    {
        System.Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public void SetTop(int numerator)
    {

        _numerator = numerator;

        // System.Console.Write("top: ");
        // string numerator = System.Console.ReadLine();

        // _numerator = Convert.ToInt32(numerator);
    }

    public void SetBottom(int denominator)
    {

        _denominator = denominator;
        
        // System.Console.Write("top: ");
        // string denominator = System.Console.ReadLine();

        // _denominator = Convert.ToInt32(denominator);
    }

    public int GetTop()
    {
        return _numerator;
    }

        public int GetBottom()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }




}