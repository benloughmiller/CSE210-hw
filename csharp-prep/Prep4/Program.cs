using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number_list = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int user_input = -1;

        while (user_input != 0) {
            Console.WriteLine("Please enter a number: ");
            user_input = int.Parse(Console.ReadLine());

            if (user_input != 0) {
                number_list.Add(user_input);
            }
        }

        int sum = 0;
        foreach (int num in number_list)
        {
            sum += num;
        }
        Console.WriteLine($"Sum: {sum}");

        float average = (float)sum / number_list.Count;
        Console.WriteLine($"Average: {average}");

        int max = 0;
        foreach (int num in number_list)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"Maximum: {max}");
    }
}