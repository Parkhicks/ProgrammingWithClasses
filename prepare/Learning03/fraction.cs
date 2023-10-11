using System.Reflection.Metadata.Ecma335;

public class fraction 
{
    private int _top = 0;
    private int _bottom = 0;


    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public fraction(int whole_number)
    {
        _top = whole_number;
        _bottom = 1;
    }
    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
        public string getfraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
        public void set_bottom(int given_num)
        {
            _bottom = given_num;
        }
        public void set_top(int given_num)
        {
            _top = given_num;
        }
        public double getdecimal()
        {
            double dec_val = _top/_bottom;
            return dec_val;
        }
            

}