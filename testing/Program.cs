// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your grade percent? ");

Console.WriteLine("This is the new stuff from my test branch 01");
string gradeinput = Console.ReadLine();
int percentage = int.Parse(gradeinput);
string letter = "";
if (percentage >= 90)
{
    Console.WriteLine("You got an A");
     letter = "A";
}
else if (percentage >= 80)
{
    Console.WriteLine("You got a B");
     letter = "B";
}
else if (percentage >=70)
{
    Console.WriteLine("You got a C");
     letter = "C";
}
else if (percentage >=60)
{
    Console.WriteLine("You got a D");
     letter = "D";
}
else
{
    Console.WriteLine("You got an F");
     letter = "F";
    
}

if (letter=="A"||letter =="B"|| letter =="C")
{
    Console.WriteLine("Congratulations you passed ");
}
else if (letter =="C"|| letter =="D" || letter =="F")
{
    Console.WriteLine("Unfortunately you didn't pass this time, keep trying!");
}