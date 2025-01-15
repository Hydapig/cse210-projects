using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letterGrade;

        if (grade >= 90)
        {
            //Console.WriteLine("You have and A.");
            letterGrade = "A";
            if (grade >= 97)
            {
                letterGrade = letterGrade + "+";
            }
            else if (grade <= 93)
            {
                letterGrade = letterGrade + "-";
            }
        }
        else if (grade <90 && grade >= 80)
        {
            //Console.WriteLine("You have a B.");
            letterGrade = "B";
            if (grade >= 87)
            {
                letterGrade = letterGrade + "+";
            }
            else if (grade <= 83)
            {
                letterGrade = letterGrade + "-";
            }
        }
        else if (grade < 80 && grade >= 70)
        {
            //Console.WriteLine("You have a C.");
            letterGrade = "C";
            if (grade >= 77)
            {
                letterGrade = letterGrade + "+";
            }
            else if (grade <= 73)
            {
                letterGrade = letterGrade + "-";
            }
        }
        else if (grade < 70 && grade >= 60)
        {
            //Console.WriteLine("You have a D.");
            letterGrade = "D";
            if (grade >= 67)
            {
                letterGrade = letterGrade + "+";
            }
            else if (grade <= 63)
            {
                letterGrade = letterGrade + "-";
            }
        }
        else
        {
            //Console.WriteLine("You have a F.");
            letterGrade = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Uh oh. You have failed the course. Better study more next time.");
        }

        Console.WriteLine($"{letterGrade}");
    }
}