using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

      
        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("That is correct :)");
            }

        }                    
    }
}