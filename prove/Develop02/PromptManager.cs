using System;
using System.Runtime.Intrinsics.Arm;

class PromptManager
{


    public List<string> _prompts = new List<string>();
    public Random _random = new Random();


    public void UpdatePromptList()
    {

        _prompts.Clear();

        StreamReader PromptsFile = new StreamReader("Prompts.txt");
        string line = PromptsFile.ReadLine();

        while (line != null)
        {
            _prompts.Add(line);
            line = PromptsFile.ReadLine();
        }

        PromptsFile.Close();

    }


    public void AddPrompt()
    {

        System.Console.WriteLine("Enter the new prompt below:");
        string newPrompt = System.Console.ReadLine();

        File.AppendAllText("Prompts.txt", Environment.NewLine + newPrompt);

    }

    public string GetPrompt()
    {

        string prompt;

        int random_prompt_index = _random.Next(_prompts.Count);
        prompt = _prompts[random_prompt_index];
        return prompt;

    }


}

        // StreamWriter PromptsFile = new StreamWriter("Prompts.txt");
        // PromptsFile.WriteLine(newPrompt);
        // PromptsFile.Close();