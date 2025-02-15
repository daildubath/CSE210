using System;

class Reference
{
    private string _reference;
    public Reference()
    {
        _reference = "--DEMO--";
    }

    public Reference(string userReference)
    {
        _reference = userReference;
    }

    public void Display()
    {
        System.Console.WriteLine(_reference);
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

}