public class journal
{
    public List <string> entries = new List<string>();

    public void add_entry(string _entry)
    {
        entries.Add(_entry);
    }

    public void iterate_entries()
    {
        foreach (string item in entries)
        {
            Console.WriteLine(item);
        }
    }

}