using System;
public class Resume{
    public string name = "";
    public List<Job> _jobs = new List<Job>();
    public string _name = "";

    public void Display(){
        Console.WriteLine(_name);
        Console.WriteLine("---------------------");
    
        foreach (Job job in _jobs){
            job.Display();
        }
    }

    }