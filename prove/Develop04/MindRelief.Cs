public class MindRelief
{
    private string _menu;
    private string _prompt;
    private string _welcome;
    private string _promptSec;
    private string _description;
    private string  _animations;


    public MindRelief(string menu, string prompt)
    {
        _menu = menu;
        _prompt = prompt;
        

    }
    public string GetMenu()
    {
        return $"{_menu}{_prompt}";
    }
    
    public MindRelief(string welcome, string description, string promptSec)
    {   
        _welcome = welcome;
        _description = description;
        _promptSec = promptSec;
    }
    public string GetDescription()
    {
        return $"{_welcome}{_description} {_promptSec}";
    }
    public string GetAnimations()
    {
        List<string>animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        foreach( string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        return _animations;
    }
}