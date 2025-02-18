using System;
using System.Runtime.CompilerServices;


public class MathAssignment : Assignment
{

    private string _textbookSetction;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        
        _textbookSetction = textbookSection;
        _problems = problems;

    }


    public string GetHomeworkList()
    {
        return $"{_textbookSetction}: {_problems}";
    }


}