using System;


class Scripture
{

    bool _end;
    private List<Verse> _verses = new List<Verse>();
    private List<int> _verseIndexes = new List<int>();
    private string _scripture; 
    Random random = new Random();

    public Scripture()
    {
        _scripture = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
        _end = false;
    }


    public void ConfigureScripture()
    {
        List<string> verses = new List<string>();
        List<char> characters = new List<char>();
        char previousCharacter = Convert.ToChar(" ");
        _verseIndexes.Add(0);
        int verseIndex= 0;

        foreach (char character in _scripture)
        {
            if ("1234567890".Contains(character))
            {
                if ("1234567890".Contains(previousCharacter))
                {
                    continue;
                }
                string theVerse = string.Join("", characters);
                verses.Add(theVerse);
                characters.Clear();   
            }
            else
            {
                characters.Add(character);
            }
            previousCharacter = character;
        }

        string lastVerse = string.Join("", characters);
        verses.Add(lastVerse);
        characters.Clear();

        foreach (string verse in verses)
        {
            _verseIndexes.Add(verseIndex);
            _verses.Add(new Verse(verse));
            verseIndex ++;
        }


    }


    public void HideWords()
    {

        {
            int count = 0;
            while ( count < 3 )
            {
                int randomVerse = random.Next(_verses.Count);
                if (!_verses[randomVerse].IsHidden())
                {
                    _verses[randomVerse].HideWord();
                    count ++;
                }
                else if (CheckHidden())
                {
                    break;
                }
                else
                {
                    continue;
                }
                
            }
        }
    }

    public bool GetFinished()
    {

        return _end;

    }

    public void Display()
    {
        foreach (Verse verse in _verses)
            {
                verse.Display();
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
    }

    public void SetScripture(string userScripture)
    {
        _scripture = userScripture;
    }

    public bool CheckHidden()
    {
        int versesFinished = 0;
        int versesTotal = 0;

        foreach (Verse verse in _verses)
        {
            versesTotal++;
            if (verse.IsHidden())
            {
                versesFinished++;
            }
        }

        if (versesTotal == versesFinished)
        {
            _end = true;
            return true;
        }
        else
        {
            return false;
        }
    }

}

    


