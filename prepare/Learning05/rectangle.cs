public class Rectangle : Shape{
    double _length = 0;
    double _width = 0;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }


    public override double GetArea()
    {
        return (_length * _width);
    }
}