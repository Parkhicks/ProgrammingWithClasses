public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


    //This is a test to make sure that branching works and then pushing them upstream


    //adding more code to hopefully get a merge conflict
}
