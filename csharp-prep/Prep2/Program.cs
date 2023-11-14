using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        The program gets a grade percentage from the user then
        procceds to convert it to int to then compare it to a set value
        to a certien letter grade.
        */

        Console.Write("What is your grade percentage? ");
        string userGradePercentage = Console.ReadLine();
        int gradePercentage = int.Parse(userGradePercentage);
        int lastDigit = gradePercentage % 10;

        char letter;
        char sign;

        if (gradePercentage >= 90)
        {
            letter = 'A';
            
            if (lastDigit < 3)
            {
                sign = '-';
            }

            else
            {
                sign = ' ';
            }
        }

        else if (gradePercentage >= 80)
        {
            letter = 'B';

            if (lastDigit >= 7)
            {
                sign = '+';
            }

            else if (lastDigit < 3)
            {
                sign = '-';
            }

            else
            {
                sign = ' ';
            }
        }

        else if (gradePercentage >= 70)
        {
            letter = 'C';

            if (lastDigit >= 7)
            {
                sign = '+';
            }

            else if (lastDigit < 3)
            {
                sign = '-';
            }

            else
            {
                sign = ' ';
            }
        }

        else if (gradePercentage >= 60)
        {
            letter = 'D';

            if (lastDigit >= 7)
            {
                sign = '+';
            }

            else if (lastDigit < 3)
            {
                sign = '-';
            }

            else
            {
                sign = ' ';
            }
        }

        else
        {
            letter = 'F';
            sign = ' ';
        }

        // Checks to see if the user passed with the gradePercentage
        // to print out a specfic string to the console.

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congrats you passed with the letter {letter}{sign}!");
        }

        else
        {
            Console.WriteLine($"Try again! You got a {letter}{sign}.");
        }
    }
}