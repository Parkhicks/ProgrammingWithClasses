public class Scripture
{
   
    //private List<>
    //private List<string> scripture_list()
    private string _scripture;

    private List<Word> _words = new List<Word>();
    private List<Word> _tempwords = new List<Word>();
    //private List<Word> _scripture = new List<Word>();

    public Scripture()
    {
        //_scripture = "Daryl stop hitting the Griddy in front of the Walkers.";
        
        //string[] _word_list = _scripture.Split(" ");
       
    }

    public void AddWord(Word w)
    {
        _words.Add(w);
    }

    
   

    public void Display_Scrip()
    {
        _tempwords.Clear();
        foreach (Word w in _words)
        {
            w.DisplayWord();
            _tempwords.Add(w);
        }

    }

    public void Display_ScripEvil()
    {
        _words.Clear();
        foreach (Word w in _tempwords)
        {
            w.DisplayEvilWord();
            _words.Add(w);
        }
        //Console.WriteLine(_scripture);
    }

    public void Display_ScripEvil_1()
    {
        _tempwords.Clear();
        foreach (Word w in _words)
        {
            w.DisplayEvilWord();
            _tempwords.Add(w);
        }
    }

    
  

}