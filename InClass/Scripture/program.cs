// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the scripture memorizer,");
Con
// See https://aka.ms/new-console-template for more information

Reference r = new Reference("D&C",66,6);
Scripture scrip_retardation = new Scripture();
string texter = "Tarry not many days in this place; go anot up unto the land of Zion as yet; but inasmuch as you can bsend, send; otherwise, think not of thy property.";
List<string> splitUp = texter.Split(" ").ToList();
foreach (var item in splitUp)
{
    Word word = new Word(item);
    scrip_retardation.AddWord(word);
}


//Scripture test_scrip = new Scripture("Daryl stop hitting the Griddy in front of the Walkers.");
// Word word_1 = new Word("Daryl");
// Word word_2 = new Word("stop");
// Word word_3 = new Word("hitting");
// Word word_4 = new Word("the");
// Word word_5 = new Word("gritty");
// Word word_6 = new Word("you're");
// Word word_7 = new Word("scaring");
// Word word_8 = new Word("the");
// Word word_9 = new Word("walkers.");


// scrip_retardation.AddWord(word_1);
// scrip_retardation.AddWord(word_2);
// scrip_retardation.AddWord(word_3);
// scrip_retardation.AddWord(word_4);
// scrip_retardation.AddWord(word_5);
// scrip_retardation.AddWord(word_6);
// scrip_retardation.AddWord(word_7);
// scrip_retardation.AddWord(word_8);
// scrip_retardation.AddWord(word_9);

scrip_retardation.Display_Scrip();
Console.WriteLine();

bool sym_status = true;
int placeholder = 1;

while (sym_status == true)
{
    string user_input = Console.ReadLine();
    if (user_input == "")
    {
        if (placeholder == 1)
        {
            scrip_retardation.Display_ScripEvil();
            placeholder -= 1;
        }
        else if (placeholder == 0)
        {
            scrip_retardation.Display_ScripEvil_1();
            placeholder += 1;
        }
    }
        
    
    else 
    {
        sym_status = false;
    }
}
scrip_retardation.Display_ScripEvil();
//user_number = int.Parse(Console.ReadLine());


//string[] input = {"Daryl", "stop", "hitting", "the", "gritty", "you're", "scaring", "the", "walkers"};

//Word word_list_12 = new Word(input);


