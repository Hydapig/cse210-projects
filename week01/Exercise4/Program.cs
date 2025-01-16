using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> numbers = new List<string>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        int input = 1;
        int sum = 0;
        int largestNumber = 0;
        
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input.ToString());
            }
        }

        foreach (string number in numbers)
        {
            sum = sum + int.Parse(number);
        }

        int average = sum / numbers.Count;

        for (int i = 0; i < numbers.Count; i++)
        {
            int number = int.Parse(numbers[i]);
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"the average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}