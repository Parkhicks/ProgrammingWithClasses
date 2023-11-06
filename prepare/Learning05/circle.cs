public class Circle : Shape
{
    double _radius = 0;

     public Circle(double radius)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return (3.14 * (_radius * _radius));
    }
}