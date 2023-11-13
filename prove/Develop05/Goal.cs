public class Goal
{
    int g_points = 0;
    string g_name = "";
    bool g_status = false;


    public Goal() 
    {
    }
    public virtual create_goal(int points, string name)
    {
        g_points = points;
        g_name = name;
    }

    public void Complete_goal()
    {
        g_status = true;
        User.gain_points(g_points);
    }
}