using System;
public class Job{
    public string _company = "";
    public string _title = "";
    public string _start_year = "";
    public string _end_year = "present";


    public void Display(){
        Console.WriteLine($"{_title} ({_company}) {_start_year}-{_end_year}");
    }
}