using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1,101);
            int GuessCount = 0;
            float Guess;
            do
            {
                GuessCount += 1;
                Console.Write("What is your guess? ");
                Guess = float.Parse(Console.ReadLine());
                if (Guess > MagicNumber)
                    Console.WriteLine("Lower");
                else if (Guess < MagicNumber)
                    Console.WriteLine("Higher");
                else
                    Console.WriteLine($"You guessed it!.It took you {GuessCount} guesses");
            } while (Guess != MagicNumber);
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}