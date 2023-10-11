using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        fraction f1 = new fraction();
        Console.WriteLine($"{f1.getfraction()}");
        Console.WriteLine($"{f1.getdecimal()}");

        fraction f2 = new fraction(6);
        Console.WriteLine($"{f2.getfraction()}");
        Console.WriteLine($"{f2.getdecimal()}");
        f2.set_bottom(4);
        Console.WriteLine($"{f2.getdecimal()}");

        fraction f3 = new fraction(2,7);
        Console.WriteLine($"{f3.getfraction()}");
        Console.WriteLine($"{f3.getdecimal()}");
        f3.set_bottom(4);
        Console.WriteLine($"{f3.getdecimal()}");

    }
    

    
}