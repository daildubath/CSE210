using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction num1 = new Fraction();
        num1.Display();
        Fraction num2 = new Fraction(5);
        num2.Display();
        Fraction num3 = new Fraction(5, 7);
        num3.Display();
        num1.SetTop(5);
        num1.SetBottom(10);
        num1.Display();
        System.Console.WriteLine(num1.GetFractionString());
        System.Console.WriteLine(num1.GetDecimalValue());


    }
}