public class Checklist : Goal
{
    int _RequiredCount;
    int _Reward;
    int count = 0;
    public Checklist()
    {

    }

 
    public override void Complete_goal(User user)
    {
        if (count == _RequiredCount)
        {
            Console.WriteLine($"Congratulations you've completed that goal {count}/{_RequiredCount}! We'll mark this one complete");
            user.gain_points(g_points);
            user.gain_points(_Reward);
        }
        else{
            count += count;
            Console.WriteLine($"Congratulations, you've completed that goal {count} times! You only have {_RequiredCount - count} left!");
            user.gain_points(g_points);
        }
        
        
    }
}