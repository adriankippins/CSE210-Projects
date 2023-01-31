using System;
using System.IO; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Date and time
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        int userNumber = 1;
        //while loop to have the code run until the user decides to exit
        while (userNumber != 5)
        {   
            ////menu items
            Console.Write("\n");
            Console.Write("1.Write:\n");
            Console.Write("2.Display:\n");
            Console.Write("3.Load:\n");
            Console.Write("4.Save:\n");
            Console.Write("5.Exit:\n");
            //prompt for input from menu
            Console.Write("Please enter an Option:\n");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            //journal class
            Journal journal = new Journal();
            journal._path1= @"journal.txt";
            //if statement to write to journal
            if (userNumber == 1)
            {   
                //prompt generator
                Prompts prompts = new Prompts();
                
                prompts._randomGenerator = "";
                Console.WriteLine(prompts._randomGenerator);
                //saving to txt file
                using (StreamWriter outputFile = new StreamWriter(journal._path1))
                {
                    Console.WriteLine(">");
                    string newEntry= Console.ReadLine();
                    outputFile.WriteLine($"{dateText}: {newEntry}");

                }
                
            }
            //display txt already input
            else if ( userNumber == 2)
            {   //saving txt to file temporary 
                string displayAll = File.ReadAllText(journal._path1);
                Console.WriteLine(displayAll);
            }
            //load saved txt by name
            else if ( userNumber ==3)

            {
                Console.WriteLine("What is the filename?");
                string loadAnswer = Console.ReadLine();
                string path3 = loadAnswer;
                if (File.Exists(path3))
                {
                    string loadTxt = File.ReadAllText(path3);
                    Console.WriteLine(loadTxt);

                    
                    
                }
                
                
            }
            //save txt file to own txt 
           else if (userNumber == 4 )

           {   
                Console.WriteLine("Save as?");
                string saved = Console.ReadLine();
                File.Copy(journal._path1, saved);
                        

                
                
            }
            //exiting code
            else if (userNumber == 5)
            {
                Console.WriteLine("Good Bye");
            }
            //message for user to try again if any number other than reqired was input
            else if (userNumber != 1-5)
            {
                Console.WriteLine("try again");
            }
            
        }

        



    }

        
  

}