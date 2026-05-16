using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game!");
        
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Console.WriteLine("Try to guess the magic number between 1 and 100.");
            
            Random randomgenerator = new Random();
            int MagicNumber = randomgenerator.Next(1, 100);

            int guess = 0;
            while (guess != MagicNumber)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < MagicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > MagicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the magic number!");
                }
            }
            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
    }
}