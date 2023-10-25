public class Assignment 
{
    protected string _student_name = "";
    protected string _topic = "";

    public Assignment(string student_name, string topic)
    {
        _student_name = student_name;
        _topic = topic;
    }
  public string GetStudentName()
    {
        return _student_name;
    }
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _student_name + " - " + _topic;
    }
}