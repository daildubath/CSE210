using System;


public class WritingAssignment : Assignment
{

    public string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string name = GetName();
        return $"{name}: {_title}";
    }



}