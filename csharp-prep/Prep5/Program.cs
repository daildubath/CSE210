using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }

        static int PromptUserNumber(){
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            return Convert.ToInt32(number);
        }

        static int SquareNumber(int number){
            return number * number;
        }

        static void DisplayResult(string name, int number){
            Console.WriteLine($"{name}, your number squared is {SquareNumber(number)}.");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(), PromptUserNumber());

    }
}