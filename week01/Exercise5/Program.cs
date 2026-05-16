using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string UserName = GetUserName();
        int UserNumber = GetUserNumber();

        int SquaredNumber = SquareNumber(UserNumber);

        DisplayResult(UserName, SquaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Number Squaring Program!");
    }
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int GetUserNumber()
    {
        Console.Write("Please enter a number to square: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");
    }
}