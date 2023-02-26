using System;

public class ReflectingActivity : MindRelief
{   
    private string _promptQ;
    private string _promptQ1;
    private string _alert;
    private string _toContinue;
    private string _beginPondering;
    public ReflectingActivity( string alert, string toContinue,string beginPondering, string welcome,string description, string promptSec) : base(welcome, description, promptSec)
    {
        _alert = alert;
        _toContinue = toContinue;
        _beginPondering = beginPondering;
    }
    public string GetPromptQ()
    {   
        
        Random rand = new Random();
        List<string> promtpQ = new List<string>();
        promtpQ.Add("\n....Reflect on a time when you felt the power of the Atonement in your life.\n");
        promtpQ.Add("\n....When was the last time you wne out of your way to help someone?\n");
        promtpQ.Add("\n....How would you feel if Christ were to return today?\n");
        promtpQ.Add("\n....What was the most fulfiulling caling you served in?\n");
        promtpQ.Add("\n....What brings you the most joy?\n");
        

        int index = rand.Next(promtpQ.Count);
        Console.WriteLine(promtpQ[index]);
        return _promptQ;
    }
    public string GetAlert()
    {
        return _alert;
    }
    public string GettoContinue()
    {
        return _toContinue;
    }
    public string GetbeginPondering()
    {
       return  _beginPondering; 
    }
    public string GetPromptQ1()
    {
        Random rand = new Random();
        List<string> promtpQ1 = new List<string>();
        promtpQ1.Add("\n....How did this make you feel? \n");
        promtpQ1.Add("\n....How can this help you in your life? \n");
        promtpQ1.Add("\n....What can you do to help smeone today? \n");
        promtpQ1.Add("\n....How can this help others? \n");
        promtpQ1.Add("\n....What changes will you make now to come closer to Christ?\n");
        promtpQ1.Add("\n....Are you spiritually motivated?\n");

        int index = rand.Next(promtpQ1.Count);
        Console.WriteLine(promtpQ1[index]);
        return _promptQ1;
    }
}