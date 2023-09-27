public class Laptop{

    private double _screensize;
    private string _OS;
    private bool _touchscreen;

    public Laptop(double screensize, string OS, bool touchscreen)
    {
        _screensize = screensize;
        _OS = OS;
        _touchscreen = touchscreen;

    }
    public void ShowDetails()
    {
        Console.WriteLine($"{_screensize} {_OS} {_touchscreen}");
    }
}