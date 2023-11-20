public class Journal
{
    public List <Entry> entries = new List<Entry>();

    public void add_entry(Entry _entry)
    {
        entries.Add(_entry);
    }
    public void iterate_entries()
    {
        foreach (Entry item in entries)
        {
            Console.WriteLine(item._date);
            Console.WriteLine(item._prompt);
            Console.WriteLine(item._response);
        }
    }

}