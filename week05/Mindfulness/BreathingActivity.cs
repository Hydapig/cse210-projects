using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            
            Console.Write("Breath out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}