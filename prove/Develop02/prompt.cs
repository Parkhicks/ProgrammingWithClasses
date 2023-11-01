using System.ComponentModel.DataAnnotations;

public class prompt
{   public List <string> prompts = new List<string>();
     
    public prompt()
    {
        prompts.Add("What was the best thing you saw someone do today?");
        prompts.Add("What is the coolest thing you did today?");
        prompts.Add("What was the nicest thing someone said to you today?");
        prompts.Add("What is something you'd never want to forget about today?");
        prompts.Add("If today was your last day, what would you regret not doing?");
        prompts.Add("When did you feel the most of any emotion? What made you feel that way?");
    }
    public string get_prompt()
    {
        var random_number = new Random();
        var _number = random_number.Next(0, prompts.Count());
        string prompt = prompts[random_number.Next(0,prompts.Count())];
        return prompt;

    }
}