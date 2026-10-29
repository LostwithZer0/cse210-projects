using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine($"Numbers in list: {numbers.Count}");
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }

        if (numbers.Count > 0)
        {
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}