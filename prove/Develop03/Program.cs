using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {  
        
        Referrence referrence = new Referrence("Psalms ", "118:24 : ");
        Console.Write(referrence.GetBookString());
        Console.Write(referrence.GetVerseString());
        Referrence referrence1 = new Referrence(" This is the day which the Lord hath made we will rejoice and be glad in it");
        File.WriteAllText("verses.txt",referrence1.GetText0());
        
        Words words = new Words();
        Console.Write(words.GetTextString());
        string[] wordi = words.GetTextString().Split(' ');
        Words words1 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words1.GetPromptString());
        string end = Console.ReadLine();
        Console.Clear();
        Scripture scripture = new Scripture($"{referrence.GetBookString()}{referrence.GetVerseString()}This is the day which the Lord hath made we will rejoice and be glad in it");
        
        StringBuilder text = new StringBuilder(scripture.GetScriptureText());
        
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("lord.", "_____");
            text.Replace("the", "");
            text.Replace("which", "____");
            text.Replace("made", "____");
            text.Replace("day,", "____");
            
            
        }
        Console.Write(text);   
        Words words2 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words2.GetPromptString());
        string end2 = Console.ReadLine();
        Console.Clear();
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("will", "____");
            text.Replace("glad", "______");
            text.Replace("the.", "_____");
            text.Replace(", we will", "__ ___");

        }
        Console.Write(text);
        Words words3 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words3.GetPromptString());
        string end3 = Console.ReadLine();
        Console.Clear();
         
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("This", "____");
            text.Replace("the", "__");
            text.Replace("it", "__");
            text.Replace("we", "___");
            text.Replace("rejoice", "____");
            text.Replace("be", "______");
            text.Replace("in it", "__ __");

        }
        Console.Write(text);
        string end4 = Console.ReadLine();
        Console.Clear();
    }

       
}