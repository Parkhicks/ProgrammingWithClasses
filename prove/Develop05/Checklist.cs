public class Checklist : Goal
{
    int g_reward;
    int g_required_time;
    int count;
    public Checklist(string type, int points, string name, int reward, int required_times)
    {
        g_status = false;
        g_type = type;
        g_points = points;
        g_name = name;
        g_reward = reward;
        g_required_time = required_times;
    }

    public string GetChecklistTime(){
        return $"{count}/{g_required_time}";
    }
    public int GetReward(){
        return g_reward;
    }
    public int GetCount(){
        return count;
    }
    public int GetRequiredTime(){
        return g_required_time;
    }
 
    public override void Complete_goal(User user)
    {
        if (count == g_required_time)
        {
            Console.WriteLine($"Congratulations you've completed that goal {count}/{g_required_time}! We'll mark this one complete");
            user.gain_points(g_points);
            user.gain_points(g_reward);
        }
        else{
            count += count;
            Console.WriteLine($"Congratulations, you've completed that goal {count} times! You only have {g_required_time - count} left!");
            user.gain_points(g_points);
        }
        
        
    }
}