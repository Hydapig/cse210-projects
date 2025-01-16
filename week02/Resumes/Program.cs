using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Console.WriteLine(job1.company);

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Console.WriteLine(job2._company);
    }
}