using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =  new List<int>();
        int start = 0;
        Console.WriteLine("Enter a number numbers you want to add to your list ");
        Console.WriteLine("Enter a your first number: ");
        string number = Console.ReadLine();
        while (start == 0)
        {
            int num = int.Parse(number);
            if (num == 0)
            {
                start = 1;
            }
            else
            {
                numbers.Add(num);
                Console.WriteLine("Enter another number, enter 0 if you're done");
                number = Console.ReadLine();
            }
            
        };
        Console.WriteLine($"The sum of those numbers is: {numbers.Sum()}");
        Console.WriteLine($"The average of those numbers is: {numbers.Average()}");
        Console.WriteLine($"The maximum of those numbers is: {numbers.Max()}");

    }
}