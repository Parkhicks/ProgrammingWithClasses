prompt prompts = new prompt();

Journal my_journal = new Journal();

int responseint = 0;
string entry_response;
string dateText = DateTime.Now.ToShortDateString();
string _prompt;
string filename = "journal.txt";

while (responseint != 5)
{
    Console.WriteLine("What would you like to do?\n1. Write \n2. Display\n3. Load \n4. Save \n5. Quit \n-----------------\n");
    responseint = 1;
    string response = Console.ReadLine();
    responseint = int.Parse(response); 
    if (responseint == 1)
    {
        Console.Write("\nChoose from the following options:\n--------------------\n");
        int count = 0;
        foreach(string singleentry in prompts.prompts)
        {
            count = count + 1;
            Console.WriteLine($"{count}. {singleentry}");
        }
        Console.Write($"{count+1} Get random prompt\n\n");
        string prompt_choice = Console.ReadLine();
        int prompt_num = int.Parse(prompt_choice);
        if (prompt_num == 7)
        {
            _prompt = prompts.get_prompt();
            Console.Write($"\n---------------------------\n \n{_prompt}\n>");

            entry_response = Console.ReadLine();
        }
        else{
            _prompt = prompts.prompts[prompt_num-1];
            Console.Write($"\n---------------------------\n \n{prompts.prompts[prompt_num-1]}\n>");
            entry_response = Console.ReadLine();
        }
        Entry entry1 = new Entry(dateText,_prompt,entry_response);
        my_journal.add_entry(entry1);
        Console.WriteLine();
    }
    else if (responseint ==2)
    {
        Console.WriteLine("Here's your current entries:\n");
        my_journal.iterate_entries();
        Console.WriteLine("\n");
    }
    else if (responseint ==3)
    {
        Console.WriteLine("You chose option 3 Load");
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string r_line in lines)
        {

            string[] broke = r_line.Split(",");
            Entry entry1 = new Entry(broke[0],broke[1],broke[2]);
            my_journal.add_entry(entry1);
        }
        Console.WriteLine("Your file has been loaded");
    }
    else if (responseint ==4)
    {
        Console.WriteLine("You chose option 4 Save");
        StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in my_journal.entries)
        {
            writer.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            
        }
        writer.Close();
        
    }
    else
    {
        Console.WriteLine("\nThanks for your time, quitting now. Have a nice day!");
    }
}