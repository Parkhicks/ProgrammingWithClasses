public class Book
{
    string _author = "";
    string _name = "";
    int _timesread = 0;
    bool _available;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
        _timesread = 0;
        _available = true;
    }

    public void hasauthor()
    {

    }
    public void Display()
    {
        Console.WriteLine($"{_name} by {_author} has been read {_timesread} times and is currently available: {_available}");
    }
    public void IsAvailable()
    {

    }
    public void TimesRead()
    {

    }
    public void CheckOut()
    {

    }
    public void CheckIn()
    {

    }
}