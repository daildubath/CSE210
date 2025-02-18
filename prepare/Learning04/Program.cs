using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment me = new MathAssignment("Joe Burrow", "Math", "5", "1 + 1");

        string mathyn = me.GetSummary();
        string mathya = me.GetHomeworkList();

        System.Console.WriteLine($"{mathyn} \n {mathya}");

        WritingAssignment we = new WritingAssignment("Brock Purdy", "Writing", "I like red because...");

        string wathyn = we.GetSummary();
        string wathya = we.GetWritingInformation();

        System.Console.WriteLine($"{wathyn} \n {wathya}");
        //                         ____
        //HERE IS THE MUFFIN MAN: (____)
    }   //                        \||||/
}