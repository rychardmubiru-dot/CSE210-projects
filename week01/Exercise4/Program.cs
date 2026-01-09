using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int UserNumber = -1;
        while (UserNumber != 0)
        {
            Console.Write("Enter number: ");
            string UserResponse = Console.ReadLine();
            UserNumber = int.Parse(UserResponse);
            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }
        int sum = 0;
        foreach (int digit in numbers)
        {
            sum += digit;
        }
        Console.WriteLine($"The total is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int digit in numbers)
        {
            if (digit > max)
            {
                max = digit;
            }
        }
        Console.WriteLine($"The biggest number is {max}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}