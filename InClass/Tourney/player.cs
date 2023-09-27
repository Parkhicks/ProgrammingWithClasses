public class Player
{
    private string _name;
    private int _jnumber;

    public Player(string name, int jersey)
    {
        _name = name;
        _jnumber = jersey;

    }

    public void Display()
    {
        Console.WriteLine($"{_name}, {_jnumber}");
    }
}