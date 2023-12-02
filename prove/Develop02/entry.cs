// using Microsoft.VisualBasic;

public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = "";

    public Entry(string date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
}