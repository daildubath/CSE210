using System;


/*
My extra is adding functionality to the prompts. 
You can add prompts yourself, and they are loaded from a
file so that once a prompt is added it stays.
*/


class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        Menu menu = new Menu();
        bool continueProgram = true;
        string userChoice;


        System.Console.WriteLine("--Welcome to your Journal--");
        System.Console.WriteLine();

        while (continueProgram)
        {
                menu.Display();
                userChoice = System.Console.ReadLine();
                System.Console.WriteLine();

                if (userChoice == "1")
                {
                        journal.AddEntry();
                }
                else if (userChoice == "2")
                {
                        journal.Display();
                }
                else if (userChoice == "3")
                {
                        journal.Save();
                }
                else if (userChoice == "4")
                {
                        journal.Load();
                }
                else if (userChoice == "5")
                {
                        journal._promptManager.AddPrompt();
                }
                else if (userChoice == "6")
                {
                        continueProgram = false;
                }
                else
                {
                        System.Console.WriteLine("Please enter 1 through 6.");
                }

        }


    }
}

/*
   Extra for the assigment is in prompt managers ability to add prompts to a text file so the 
*/



// ENTRY TEST

        // Entry entry_1 = new Entry();
        // entry_1._prompt = "If you were an animal, what would you be? What kind of animal is most like me?";
        // entry_1._date = "5/7/2022";
        // entry_1._response = "I think that I'm a badger.";

        // entry_1.Display();



// PROMPT TEST

        // string prompt = "";

        // PromptManager promptManager = new PromptManager();

        // promptManager.UpdatePromptList();

        // for (int i = 0; i < 6; i++)
        // {
        //     prompt = promptManager.GetPrompt();
        //     System.Console.WriteLine(prompt);  
        // }

        // promptManager.AddPrompt();
        // promptManager.AddPrompt();
        // promptManager.AddPrompt();
        // promptManager.AddPrompt();

        // promptManager.UpdatePromptList();

        // for (int i = 0; i < 6; i++)
        // {
        //     prompt = promptManager.GetPrompt();
        //     System.Console.WriteLine(prompt);  
        // }

// MENU TEST (like you need it)

        // Menu menu = new Menu(); 
        
        // menu.Display();
        // menu.Display();
        // menu.Display();


// JOURNAL TEST

        // Journal journal = new Journal();

        // journal.AddEntry();
        // journal.AddEntry();
        // journal.AddEntry();
        // journal.AddEntry();
        // journal.Save();
        // journal.Load();