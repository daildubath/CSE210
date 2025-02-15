using System;

class Program
{
    static void Main()
    {
        string _response = "";
        Reference _reference = new Reference();
        Scripture _scripture = new Scripture();

        Console.Clear();

        System.Console.WriteLine("Welcome to the scripture memorization program!");
        System.Console.WriteLine();
        System.Console.WriteLine("Please paste your scripture below with verse numbers as one line. Hit enter for demo.");
        _response = System.Console.ReadLine();

        if (_response != "")
        {
            _scripture.SetScripture(_response);
            System.Console.Write("Please put in your scripture's reference (John 3:19): ");
            _response = System.Console.ReadLine();
            _reference.SetReference(_response);
        }
        _scripture.ConfigureScripture();

        Console.Clear();

        while (!_scripture.GetFinished() && !_response.Equals("quit"))
        {

            _reference.Display();
            _scripture.Display();

            _response = System.Console.ReadLine();
            Console.Clear();
            _scripture.HideWords();

        }
    }
}