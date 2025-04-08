public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected DateTime _startTime;
    protected DateTime _endTime;

    public Activity(){}
    // public Activity(string name, string description, int duration)
    // {
    //     _name = name;
    //     _description = description;
    //     _duration = duration;
    // }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have chosen the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow many seconds would you like to spend in your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Great job completing the {_name} Activity!");
        DisplaySpinner(5);
    }

    public void DisplaySpinner(int seconds)
    {
        List<string> _spinner = new List<string> {"|","/","-","\\"};
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(seconds);
        int i = 0;
        Console.CursorVisible = false;

        while (DateTime.Now < _endTime)
        {
            string s = _spinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= _spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}