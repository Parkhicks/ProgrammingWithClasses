using System;
using System.Globalization;

class Program
{

    void DisplayWelcome()
    {
        Console.WriteLine("Hello and welcome to the program!");
    }
    string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string uname = Console.ReadLine();
        return uname;
    } 
    int PromptUserNum()
    {
        Console.WriteLine("What is your favorite number? ");
        string nums = Console.ReadLine();
        int num = int.Parse(nums);
        return num;
    }
    int squarednum(int num)
    {
        int squarenumber = num * num;
        return squarenumber;
    }
    void result(int num, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {num} ");
    }
}