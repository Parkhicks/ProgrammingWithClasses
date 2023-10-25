using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");


        Assignment test = new Assignment("Parker Hicks", "Religion");
        string status = test.GetSummary();
        Console.WriteLine(status);
    }

    
}