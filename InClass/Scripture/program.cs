// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the scripture memorizer,");

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



