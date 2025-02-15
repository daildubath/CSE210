using System;

class Word
{

private string _word;
private bool _hidden;

public Word()
{
    _word = "-error-";
    _hidden = false;
}

public Word(string theWord)
{
    _word = theWord;
    _hidden = false;

}

public void HideWord()
{
    _hidden = true;
}

public void Display()
{

    if (_hidden)
    {
        foreach (char character in _word)
        {
            System.Console.Write("_");
        }
    }
    else
    {
        System.Console.Write(_word);
    }

}

public bool GetState()
{
    return _hidden;
}


}