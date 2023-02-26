using System;

public class ListingActivity : MindRelief
{
    private string _listResponses;
    private string _responses;
    

    
    public ListingActivity(string listResponses, string welcome,string description, string promptSec) : base(welcome, description, promptSec)
    {
        _listResponses = listResponses;
    }
    public string GetListResponses()
    {
        return _listResponses;
    }
    public string GetResponses()
    {
        Random rand = new Random();
        List<string> responses = new List<string>();
        responses.Add("\n....What are 10 things that are most important to you? \n");
        responses.Add("\n....What makes you feel God's love the most? \n");
        responses.Add("\n....List 5 people that has positively impacted your life. \n");
        

        int index = rand.Next(responses.Count);
        Console.WriteLine(responses[index]);
        return _responses;
    }
}   