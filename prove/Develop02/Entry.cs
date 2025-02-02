using System;

class Entry
{

    public string _prompt = "";
    public string _response = "";
    public string _date = "";


    public void Display()
    {

        System.Console.WriteLine($"--{_date}--");
        System.Console.WriteLine(_prompt);
        System.Console.WriteLine("-----------------------------------------------");
        System.Console.WriteLine(_response);

    }

}