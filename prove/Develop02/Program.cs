prompt entry = new prompt();
entry.get_prompt();
Console.WriteLine("Choose from the following options:");
int count = 0;
foreach(string singleentry in entry.prompts)
{
    count = count + 1;
    Console.WriteLine($"{count}. {singleentry}");
}
entry.name = "andres";
Console.WriteLine($"{entry.name}"); 