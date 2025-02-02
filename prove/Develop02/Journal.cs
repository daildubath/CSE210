using System;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    string _fileName = "";
    public PromptManager _promptManager = new PromptManager();

    List<Entry> _entries = new List<Entry>();
    

    


    public void AddEntry()
    {

        Entry entry = new Entry();

        _promptManager.UpdatePromptList();
        entry._prompt = _promptManager.GetPrompt();

        System.Console.WriteLine();
        System.Console.Write("What is the date for the entry? ");
        entry._date = System.Console.ReadLine();

        System.Console.WriteLine(entry._prompt);

        System.Console.WriteLine("-----------------------------------------------");

        entry._response = System.Console.ReadLine();

        System.Console.WriteLine();

        _entries.Add(entry);

    }

    public void Save()
    {

        GetTextFile();
        System.Console.WriteLine();

        Thread.Sleep(1000);

        foreach (Entry entry in _entries)
        {

            File.AppendAllText(_fileName, Environment.NewLine);
            File.AppendAllText(_fileName, Environment.NewLine + $"-{entry._date}-");
            File.AppendAllText(_fileName, Environment.NewLine + entry._prompt);
            File.AppendAllText(_fileName, Environment.NewLine + "-----------------------------------------------");
            File.AppendAllText(_fileName, Environment.NewLine + entry._response);
        
        }

        System.Console.WriteLine("Complete");
        System.Console.WriteLine();

    }

    public void Display()
    {

        System.Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            entry.Display();
            System.Console.WriteLine();
        }

        System.Console.Write("Hit enter to go back to the menu.");
        System.Console.ReadLine();

    }



    public void Load()
    {


        GetTextFile();

        StreamReader entryFile = new StreamReader(_fileName);
        string line = entryFile.ReadLine();

        while (line != null)
        {
            System.Console.WriteLine(line);
            line = entryFile.ReadLine();
        }

        entryFile.Close();

        System.Console.WriteLine();
        System.Console.Write("Hit enter to go back to the menu.");
        System.Console.ReadLine();

    }


    public void GetTextFile()
    {
        System.Console.Write("What is the name of the text file you would like to load or save to? ");
        _fileName = System.Console.ReadLine();
    }


}