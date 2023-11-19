public class Eternal : Goal
{

    int high =0;


    public Eternal(string type, int points, string name) 
    {
        g_status = false;
        g_type = type;
        g_points = points;
        g_name = name;
    }

    public override void Complete_goal(User user)
    {
        user.gain_points(g_points);
        high += 1;
    }

    public int GetScore(){
        return high;
    }
    public void SetHigh(int High)
    {
        high = High;
    }
}