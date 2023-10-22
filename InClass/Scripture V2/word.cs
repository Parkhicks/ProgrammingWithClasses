using System.Reflection.Metadata.Ecma335;

public class Word
{
    //private string _word_1;
    private string _word;
    private int _status;

    //private string[] _words;
    public Word(string word,int status)
    {
        _word = word;
        _status = status;
    }

    public string DisplayWord()
    {
        return _word;
    }
    public int DisplayStat()
    {
        return _status;
    }
    public void Changestat()
    {
        _status = 0;
    }
    public void Changeword()
    {
        _word = "_";
    }
}