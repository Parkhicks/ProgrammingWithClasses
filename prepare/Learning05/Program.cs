using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2);
        Rectangle rectangle = new Rectangle(2,3);
        Circle circle = new Circle(5);

        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
    }
}