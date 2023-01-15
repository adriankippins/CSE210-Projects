using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name?: ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your Last name?: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"The name is {lastName}, {firstName} {lastName}.");

    }
}