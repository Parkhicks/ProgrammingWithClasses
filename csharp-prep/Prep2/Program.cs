using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradepercent = int.Parse(UserInput);
        if (gradepercent >= 90)
        {
            Console.WriteLine("You got an A");
            string result =("pass");
        }
        else if (gradepercent >= 80)
        {
            Console.WriteLine("You got a B");
            string result =("pass");
        }
        else if (gradepercent >= 70)
        {
            Console.WriteLine("You got a C");
            string result =("pass");
        }
        else if (gradepercent >= 60)
        {
            Console.WriteLine("You got a D");
            string result =("fail");
        }
        else
        {
            Console.WriteLine("You got an F");
            string result =("fail");
        };

        if (result == "pass")
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else if (result == "fail")
        {
            Console.WriteLine("Uh Oh, looks like you didn't pass this time, but keep going, you got this!");
        }
        else 
        {
            Console.WriteLine("Error");
        }


    }
}