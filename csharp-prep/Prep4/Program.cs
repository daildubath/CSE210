using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<int> allNumbers;
        allNumbers = new List<int>();
        Console.WriteLine("Enter numbers. Type 0 when you are finished.");
        do
        {
            Console.Write("-");
            string strumber = Console.ReadLine();
            number = Convert.ToInt32(strumber);
            if (number != 0){
                allNumbers.Add(number);
            }
        }while (number != 0);

        int sum = 0;
        float average = 0;
        int max = 0;
        int min = allNumbers[0];

        foreach (int num in allNumbers)
        {
             sum = sum + num;
             if (num > max){
                max = num;
             }
             if (num < min){
                min = num;
             }
        }

        average = sum / allNumbers.Count();

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The maximum is {max}.");
        Console.WriteLine($"The minimum is {min}.");



    }
}