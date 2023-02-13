using System;

public class Referrence
{
    private string _text;
    private string _book;
    private string _verse;
    
    
    public Referrence()
    {
        _text = "This is the day which the Lord hath made; we will rejoice and be glad in it.:\n";
       
        
    }
    public Referrence(string text0)
    {
        _text = text0;
    }
    public string GetText0()
    {
        return _text;
    }
   

    public Referrence( string book,string verse)
    {
        _book = book;
        _verse = verse;
    }
    public string GetBookString()
    {
        return _book;
    }
    public string GetVerseString()
    {
        return _verse;
    }
    
}