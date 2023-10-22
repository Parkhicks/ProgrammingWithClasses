public class Reference
{
    string _book = "";
    int _chapter = 0;
    int _fverse = 0;
    int _lverse = 0;
    int _verse = 0;
    
    public Reference(string book, int chapter, int fverse, int lverse){
        _book = book;
        _chapter = chapter;
        _fverse = fverse;
        _lverse = lverse;

    }
       public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public void DisplayRef1(){
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
    public void DisplayRef2(){
        Console.WriteLine($"{_book} {_chapter}:{_fverse}-{_lverse}");
    }
}