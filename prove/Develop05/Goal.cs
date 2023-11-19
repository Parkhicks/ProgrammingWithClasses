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
    public int GetPoints(){
        return g_points;
    }
    public string Display_Status()
    {
        if (g_status == false){
            return "[ ]";
        }
        else {
            return "[x]";
        }
    }
    public bool Get_Status()
    {
        return g_status;
    }
    public string Get_Name()
    {
        return g_name;
    }
    public void set_status(bool status)
    {
        g_status = status;
    }
   

    
}