using System.Runtime.CompilerServices;

public class Scripture1
{
    private List<Word> _full_scripture = new List<Word>();
    private List<string> _processed = new List<string>();


    public Scripture1()
    {}

    public void AddWord(Word _word)
    {
    _full_scripture.Add(_word);
    _processed.Add(_word.DisplayWord());
    }

    //public void print_full_scrip(Reference r)
    //{
        //r.DisplayRef();
        //foreach (string item in _processed)
        //{
            //Word this_word = item.DisplayWord();
            //Console.Write($"{this_word} ");
        //}
    //}

    public void hide_random_word()
    {
        int count = 0;
        foreach (Word item in _full_scripture)
        {
            count += 1;

        }
            Random rando = new Random();
            int rando_index = rando.Next(0,count);
            _full_scripture[rando_index].Changestat();
            _processed[rando_index]= "______";
    }
    public void print_scrip(Reference r)
    {
        r.DisplayRef1();
        foreach (string Item in _processed)
        {
            Console.Write($"{Item} ");
        }
    }
    public void print_scrip_2(Reference r )
    {
        r.DisplayRef2();
        foreach (string Item in _processed)
        {
            Console.Write($"{Item} ");
        }
    }
}