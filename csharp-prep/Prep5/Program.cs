using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello and welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string uname = Console.ReadLine();
            return uname;
        } 
        static int PromptUserNum()
        {
            Console.WriteLine("What is your favorite number? ");
            string nums = Console.ReadLine();
            int num = int.Parse(nums);
            return num;
        }
        static int squarednum(int num)
        {
            int squarenumber = num * num;
            return squarenumber;
        }
        static void result(int num, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {num} ");
        }
        DisplayWelcome();
        string uname = PromptUserName();
        int unum = PromptUserNum();
        int math = squarednum(unum);
        result(math,uname);
    }
}