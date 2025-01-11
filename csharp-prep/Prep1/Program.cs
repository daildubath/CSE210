using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the strings from the user
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        // Console.Write("Your name is ");
        // Console.Write(LastName);
        // Console.Write(", ");
        // Console.Write(FirstName);
        // Console.Write(" ");
        // Console.Write(LastName);
        // Console.WriteLine(".");

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");

    }
}

