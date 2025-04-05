using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Andrew","Multiplication","3.4","1-12");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Blake","American History","The Causes of the American Civil War");
        Console.WriteLine(writing1.GetWritingInformation());

    }
}