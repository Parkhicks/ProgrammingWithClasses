public class User
{
    private int score = 0;
    string filename = "goals.txt";



    public User()
    {}

    public void gain_points(int points)
    {
        score += points;
    }
    public int get_score()
    {
        return score;
    }
    public void Save(List<Simple> slist, List<Eternal> elist, List<Checklist> clist)
    {
        StreamWriter writer = new StreamWriter(filename);
        string line;
        line = $"{score}";
        writer.WriteLine(line);
        foreach (Simple item in slist)
        {
            line = $"{item.Get_type()},{item.Get_Name()},{item.GetPoints()},{item.Get_Status()}";
            writer.WriteLine(line);
        }
        foreach (Eternal item in elist)
        {
            line = $"{item.Get_type()},{item.Get_Name()},{item.GetPoints()},{item.Get_Status()},{item.GetScore()}";
            writer.WriteLine(line);
        }
        foreach (Checklist item in clist)
        {
            line = $"{item.Get_type()},{item.Get_Name()},{item.GetPoints()},{item.Get_Status()},{item.GetReward()},{item.GetCount()},{item.GetRequiredTime()}";
            writer.WriteLine(line);
        }
        writer.Close();
    }
    public void Load(List<Simple> slist, List<Eternal> elist, List<Checklist> clist)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        score = int.Parse(lines[0]);
        int counter = 1;
        foreach (string line in lines)
        {
            if (counter > (lines.Count()-1))
            {
                Console.WriteLine("");
            }
            else
            {
                string recieved_g = lines[counter];
                string[] attributes = recieved_g.Split(",");
                if (attributes[0] == "S")
                {
                    Simple simple = new Simple(attributes[0],int.Parse(attributes[2]),attributes[1]);
                    simple.set_status(bool.Parse(attributes[3]));
                    slist.Add(simple);
                }
                else if (attributes[0] == "E")
                {
                    Eternal eternal = new Eternal(attributes[0],int.Parse(attributes[2]),attributes[1]);
                    eternal.set_status(bool.Parse(attributes[3]));
                    eternal.SetHigh(int.Parse(attributes[4]));
                    elist.Add(eternal);
                }
                else if (attributes[0] == "C")
                {
                    Checklist checklist = new Checklist(attributes[0],int.Parse(attributes[2]),attributes[1],int.Parse(attributes[4]),int.Parse(attributes[6]));
                    checklist.set_status(bool.Parse(attributes[3]));
                    checklist.set_count(int.Parse(attributes[5]));
                    clist.Add(checklist);
                }
            }
            counter += 1;     
        }
        
    }
}