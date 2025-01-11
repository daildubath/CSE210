using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string UserGrade = Console.ReadLine();

        int grade = int.Parse(UserGrade);

        string LetterGrade = "";

        if (grade >= 90)
        {
            LetterGrade = "A";
        }
        else if (grade >= 80)
        {
            LetterGrade = "B";
        }
        else if (grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (grade >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is an {LetterGrade}.");
        if (grade >= 70)
        {
            Console.WriteLine("You will pass the course. Congradulations!");
        }
        else 
        {
            Console.WriteLine("You will fail the course. ");
        }




    }
}