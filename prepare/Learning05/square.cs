public class Square : Shape{
    double _side = 0;

    public Square(double side)
    {
        _side = side;
    }


    public override double GetArea()
    {
        return (_side * _side);
    }
}