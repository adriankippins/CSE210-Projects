using System;


public class Prompts

{
   //List<string> _randomGenerator = new List<string>();
   public string _randomGenerator;
   

   

   

   public Prompts()
   {
    Random random = new Random();
    List<string> test = new List<string>();
    test.Add("What was interesting about your day?");
    test.Add("Did you learn anything new today?");
    test.Add("Share an impression you had while studying the scripturest today.");
    test.Add("What can you do to come closer to Christ today?");
    int index = random.Next(test.Count);
    Console.WriteLine(test[index]);


   }

    public void randomPrompt()

    {
        Console.WriteLine(_randomGenerator);
    }
  
    

    

}