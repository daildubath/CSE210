using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int myNumber = randomGenerator.Next(1, 11);

        int intGuess = 0;
        int userTrys = 0;

        Console.Write("Guess the number between 1 and 10 I'm thinking of: ");

        do{

        string user_guess = Console.ReadLine();
        intGuess = Convert.ToInt32(user_guess);
        userTrys++;

        if (intGuess > myNumber){
            Console.WriteLine("Lower");
        }
        else if (intGuess < myNumber){
            Console.WriteLine("Higher");
        }
        } while (intGuess != myNumber);
        
        if (userTrys < 2){
            Console.WriteLine("BANG! On the money.");
        }
        else{
            Console.WriteLine("You got it!");
        }

         

    }
}