using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._company = "Momma's Home";
       job1._title = "Mom";
       job1._start_year = "1998"; 
       Job job2 = new Job();
       job2._company = "Momma's Homes";
       job2._title = "Moms";
       job2._start_year = "2001";

    //    job1.Display();
    //    job2.Display();

       Resume momma = new Resume();
       momma._name = "Susan";
       momma._jobs.Add(job1);
       momma._jobs.Add(job2);

       momma.Display();



    }
}