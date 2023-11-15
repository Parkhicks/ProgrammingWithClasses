public abstract class Goal
{
    protected int g_points;
    protected string g_name;
    protected bool g_status;
    protected string g_type;


    public virtual void Complete_goal(User user)
    {
        g_status = true;
        user.gain_points(g_points);
    }
    public string Get_type()
    {
        return g_type;
    }
    public string Get_Status()
    {
        if (g_status == false){
            return "[]";
        }
        else {
            return "[x]";
        }
    }

    
}