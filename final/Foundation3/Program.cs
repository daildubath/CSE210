class Program
{
    static void Main(string[] args)
    {
        Outdoor outdoor = new Outdoor("Kansas City Chiefs Losing", "Bout time!", "Patrick Mahomes retirement", "12:30 AM", "Sunny Side Up");
        outdoor.SetAddress("1 Arrowhead Drive", "Kansas City", "Missouri", "United States");
        Console.WriteLine($"Short: {outdoor.ShortDescription()}");
        Console.WriteLine($"Standard: {outdoor.StandardDetails()}");
        Console.WriteLine($"Full: {outdoor.FullDetails()}");

        System.Console.WriteLine("\n----------------------------------------------------\n");

        Lecture lecture = new Lecture("How I met your Mother", "For those who will, and those who don't", "April 1st", "27:30 Military Time", "Elon Musk", 666);
        lecture.SetAddress("Cloud 9", "Atlantis", "Hawaii", "Atlantic Ocean");
        Console.WriteLine($"Short: {lecture.ShortDescription()}");
        Console.WriteLine($"Standard: {lecture.StandardDetails()}");
        Console.WriteLine($"Full: {lecture.FullDetails()}");

        System.Console.WriteLine("\n----------------------------------------------------\n");

        Reception reception = new Reception("Andrew & Kylie", "You know what? It already Happened", "March 22, 2025", "6:00 PM", "myemail@gmail.com");
        reception.SetAddress("Banana", "Banana", "Hannah", "Montana");
        Console.WriteLine($"Short: {reception.ShortDescription()}");
        Console.WriteLine($"Standard: {reception.StandardDetails()}");
        Console.WriteLine($"Full: {reception.FullDetails()}");


    }
}