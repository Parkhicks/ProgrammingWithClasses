using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess = 101;
        Console.WriteLine("Guess my number between 0-100! ");
        while (guess != magic)
        {  
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            if (guess>magic)
            {
                Console.WriteLine("That is higher then the magic number ");
                Console.WriteLine("Try again ");
            }
            else if (guess < magic)
            {
                Console.WriteLine("That is lower then the magic number ");
                Console.WriteLine("Try again ");
            }
            else if(guess == magic)
            {
                Console.WriteLine("Thats correct, thats the magic number!");
            }
        }
    }    
}