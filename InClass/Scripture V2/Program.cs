using System.Net;

Console.WriteLine("Welcome to the scripture memorizer,");

// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nPlease enter the Book you're working in today: ");
string _book = Console.ReadLine();
Console.WriteLine("\nPlease enter the Chapter you're working in today: ");
var _chap = int.Parse(Console.ReadLine());
Console.WriteLine("Are you focusing on more than one verse? hit y for yes or n for no: ");
var _verses = Console.ReadLine();
if (_verses == "y")
{
    Console.WriteLine("\nPlease enter the beginning verse you're working on today: ");
    var _first_verse = int.Parse(Console.ReadLine());
    Console.WriteLine("\nPlease enter the ending verse you're working on today: ");
    var _last_verse = int.Parse(Console.ReadLine());
    Console.WriteLine("\nPlease type out the entire scripture: ");
    string scripture_input = Console.ReadLine();
    Console.WriteLine("");
    Reference r = new Reference(_book, _chap, _first_verse, _last_verse);
    Scripture1 working_scrip = new Scripture1();
    List<string> script_list = scripture_input.Split(" ").ToList();

    foreach (var item in script_list)
    {
        Word pro_word = new Word(item, 1);
        working_scrip.AddWord(pro_word);
    }
    int proceed = 1;

    while (proceed == 1)
    {
        working_scrip.print_scrip_2(r);
        Console.WriteLine("\n");
        working_scrip.hide_random_word();
        Console.WriteLine("type q to exit or hit any other key to hide more words.\n");
        if (Console.ReadLine() == "q")
        {
            proceed = 0;
        }
    }
}
else if (_verses == "n")
{
    Console.WriteLine("\nPlease enter the verse you're working on today: ");
    var _verse = int.Parse(Console.ReadLine());
    Console.WriteLine("\nPlease type out the entire scripture: ");
    string scripture_input = Console.ReadLine();
    Console.WriteLine("");
    Reference r = new Reference(_book, _chap, _verse);
    Scripture1 working_scrip = new Scripture1();
    List<string> script_list = scripture_input.Split(" ").ToList();

    foreach (var item in script_list)
    {
        Word pro_word = new Word(item, 1);
        working_scrip.AddWord(pro_word);
    }
    int proceed = 1;

    while (proceed == 1)
    {
        working_scrip.print_scrip(r);
        Console.WriteLine("\n");
        working_scrip.hide_random_word();
        Console.WriteLine("type q to exit or hit any other key to hide more words.\n");
        if (Console.ReadLine() == "q")
        {
            proceed = 0;
        }
    }
}





