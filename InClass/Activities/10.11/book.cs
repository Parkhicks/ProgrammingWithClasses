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

    public void hasauthor(string author)
    {
        return _author.Contains(author);
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
        return _timesread;
    }
    public void CheckOut()
    {
        _timesread += 1;
        _available = false;
    }
    public void CheckIn()
    {
        _available = true;
    }
}