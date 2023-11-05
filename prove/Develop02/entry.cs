// using Microsoft.VisualBasic;

public class entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = "";

    public string create_entry(string date, string prompt, string response)
    {
        return ($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n\n");
    }
}