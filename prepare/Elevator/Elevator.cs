public class Elevator
{

    private bool dooropen = true;
    protected int _range = 30;
    private int _floor = 1;


    public Elevator()
    {
    }

    public void open_door()
    {
        Console.WriteLine("Opening Door");
        dooropen = true;
    }
    public void close_door()
    {
        Console.WriteLine("Closing Door");
        dooropen = false;
    }
    public void move_floor(int password)
    {
        int condition = 1;
        while (condition == 1)
        {
            Console.WriteLine ($"Pick a floor between 1-{_range}");
            int choice = int.Parse(Console.ReadLine());

            if (_floor == choice)
            {
                Console.WriteLine("You are already on that floor, please pick another.");
            }
            else if (choice < 0 || choice > _range)
            {
                Console.WriteLine("Sorry that floor doesn't exist, please pick again");
            }
            else if (choice == 31)
            {
                Console.WriteLine("Please enter your pin: ");
                int pin = int.Parse(Console.ReadLine());
                if (pin == password)
                {
                    Console.WriteLine("\n\n");
                    _floor = choice;
                    close_door();
                    Console.WriteLine("Insert elevator music here");
                    Console.WriteLine($"Welcome to floor: {choice}");
                    open_door();
                    condition = 2;
                }
                else
                {
                    Console.WriteLine("Incorrect Password, please try again");
                }

            }
            else if (choice >0 || choice <_range)
            {
                Console.WriteLine("\n\n");
                _floor = choice;
                close_door();
                Console.WriteLine("Insert elevator music here");
                Console.WriteLine($"Welcome to floor: {choice}");
                open_door();
                condition = 2;
            }
        }
       
    }
} 