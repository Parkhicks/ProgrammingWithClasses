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
    public string Get_Status()
    {
        if (g_status == false){
            return "[ ]";
        }
        else {
            return "[x]";
        }
    }
    public string Get_Name()
    {
        return g_name;
    }
   
   
    public void Save(StreamWriter writer)
    {
        writer.WriteLine($"{g_type},{g_name},{g_points}, {g_status}");
        writer.Close();
    }
    //public void Load(string filename)
    //{
    //    _entries.Clear();
    //    StreamReader reader = new StreamReader(filename);
    //    while (!reader.EndOfStream)
    //    {
//            string prompt = reader.ReadLine();
//            string response = reader.ReadLine();
   //         string date = reader.ReadLine();
  //          var timestamp = DateTime.Parse(date);
//
  //          Text text = new Text();
  //          text._prompt = prompt;
  //          text._content = response;
  //          text._timestamp = timestamp;
   //         _entries.Add(text);
    
}