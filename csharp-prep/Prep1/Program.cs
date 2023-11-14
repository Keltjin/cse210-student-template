using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        The program prompts the users for their first and last name.
        The program then displays the variables into the Console.
        */

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}