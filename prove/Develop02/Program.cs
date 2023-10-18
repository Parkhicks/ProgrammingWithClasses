prompt prompts = new prompt();
entry entry1 = new entry();
journal my_journal = new journal();

int responseint = 0;
string entry_response = "";
string dateText = DateTime.Now.ToShortDateString();

while (responseint != 5)
{
    Console.WriteLine("What would you like to do?\n1. Write \n2. Display\n3. Load \n4. Save \n5. Quit \n-----------------\n");
    responseint = 1;
    string response = Console.ReadLine();
    responseint = int.Parse(response); 
    if (responseint == 1)
    {
        Console.WriteLine("\nChoose from the following options:\n--------------------\n");
        int count = 0;
        foreach(string singleentry in prompts.prompts)
        {
            count = count + 1;
            Console.WriteLine($"{count}. {singleentry}");
        }
        Console.WriteLine($"{count+1} Get random prompt\n");
        string prompt_choice = Console.ReadLine();
        int prompt_num = int.Parse(prompt_choice);
        if (prompt_num == 7)
        {
            Console.WriteLine($"\n---------------------------\n \n{prompts.get_prompt}\n>");
            entry1._response = Console.ReadLine();
            entry1._date = dateText;
        }
        else{
            entry1._prompt = prompts.prompts[prompt_num-1];
            Console.WriteLine($"\n---------------------------\n \n{prompts.prompts[prompt_num-1]}\n>");
            entry1._response = Console.ReadLine();
            entry1._date = dateText;
        }
        my_journal.add_entry(entry1._prompt, entry1._date,entry1._response);
    }
    else if (responseint ==2)
    {
        Console.WriteLine("You chose option 2");
        my_journal.iterate_entries();
    }
    else if (responseint ==3)
    {
        Console.WriteLine("You chose option 3");
    }
    else if (responseint ==4)
    {
        Console.WriteLine("You chose option 4");
    }
    else
    {
        Console.WriteLine("\nThanks for your time, quitting now. Have a nice day!");
    }
}