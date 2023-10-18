using System.Reflection.Metadata.Ecma335;

public class Word
{
    //private string _word_1;
    private string _word;

    //private string[] _words;
    public Word(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        Console.Clear();
        Console.Write(_word);
        Console.Write(" ");
    }

    public void DisplayEvilWord()
    //not working because words set to false are in scripture
    {
        Random rnd = new Random();
        int status = rnd.Next(0, 2);
        int word_length = _word.Length;
        string blanked = "";
        string underscore = "_";
        bool repeat_check = _word.Contains(underscore);
        if (status == 1 || repeat_check == true)
        {
            if (word_length == 1)
            {
                blanked = "_";
            }
            else if (word_length == 2)
            {
                blanked = "__";
            }
            else if (word_length == 3)
            {
                blanked = "___";
            }
            else if (word_length == 4)
            {
                blanked = "____";
            }
             else if (word_length == 5)
            {
                blanked = "_____";
            }
             else if (word_length == 6)
            {
                blanked = "______";
            }
             else if (word_length == 7)
            {
                blanked = "_______";
            }
             else if (word_length == 8)
            {
                blanked = "________";
            }
            Console.Write(blanked);
            Console.Write(" ");
            //Console.Write(repeat_check);
        }
        else
        {
           Console.Write(_word);
            Console.Write(" "); 
        }
        //int month  = rnd.Next(1, 13);  // creates a number between 1 and 12
    }

    public void DisplaySciptureDec()
    {
        //does the foreach loop again but randomizes if the 
        //word will be blank, BUT bases itself off of the previously used list
    }

    //private List<Word> _word_list = new List<Word>();

//LOOK HERE FOR THE FOREACH
    //string[] _word_list = scripture_1.Split(" ");

    //string phrase = "The quick brown fox jumps over the lazy dog.";
//string[] words = phrase.Split(' ');

//foreach (var word in words)

    //System.Console.WriteLine($"<{word}>");




}