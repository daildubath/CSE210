using System;

class Verse
{

private List<Word> _words = new List<Word>();
private string _text;
private List<int> _wordIndexes = new List<int>();
private Random random = new Random();
private bool _hidden = false;



public Verse()
{
    _text = "";
}

public Verse(string text)
{
    List<string> words = new List<string>();
    List<char> characters = new List<char>();
    int wordIndex= 0;

    foreach (char character in text)
    {
        if (character != Convert.ToChar(" "))
        {
            characters.Add(character);
        }
        else
        {
            string theWord = string.Join("", characters);
            words.Add(theWord);
            characters.Clear();
        }
    }

    string lastWord = string.Join("", characters);
    words.Add(lastWord);
    characters.Clear();

    foreach (string word in words)
    {
        _wordIndexes.Add(wordIndex);
        _words.Add(new Word(word));
        wordIndex += 1;
    }

}

public void Display()
{
    foreach (Word word in _words)
    {
        System.Console.Write(" ");
        word.Display();
    }
}

public void HideWord()
{
    if (_wordIndexes.Count() != 0)
    {
        int removeIndex = random.Next(_wordIndexes.Count());
        _words[_wordIndexes[removeIndex]].HideWord();
        _wordIndexes.RemoveAt(removeIndex);
    }
    if (_wordIndexes.Count() == 0)
    {
        _hidden = true;
    }
}

public bool IsHidden()
{
    return _hidden;
}


}