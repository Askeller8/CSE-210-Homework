using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int UserNumber = -1;
        while (UserNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");

            string UserResponse = Console.ReadLine();
            UserNumber = int.Parse(UserResponse);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers you entered is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers you entered is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number you entered is: {max}");
    }
}