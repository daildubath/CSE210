using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> group1 = new List<Activity>{new Running("03 Nov 2022", 30, 3.0), new Cycling("03 Nov 2022", 30, 6.0), new Swimming("03 Nov 2022", 30, 60.0)};
        List<Activity> group2 = new List<Activity>{new Running("15 Aug 2023", 120, 14.0), new Cycling("23 Jan 2024", 120, 7.0), new Swimming("03 Nov 2022", 120, 280.0)};
        
        foreach (Activity activity in group1)
        {
            Console.WriteLine(activity.GetSummary());
        }

        System.Console.WriteLine();

        foreach (Activity activity in group2)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}