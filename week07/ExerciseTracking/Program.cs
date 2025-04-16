using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ExerciseTracking Project.");

        List<Activity> _activityList =
        [
            new RunningActivity(new DateTime(2025, 04, 15), 30, 5),
            new CyclingActivity(new DateTime(2025, 04, 15), 60, 10),
            new SwimmingActivity(new DateTime(2025, 04, 15), 20, 15),
        ];
        // _activityList.Add(new SwimmingActivity("20 April 2025", 20, 8));

        foreach (var exercise in _activityList)
        {
            Console.WriteLine(exercise.GetSummary());
        }

    }
}