public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    protected Random random = new Random();

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    }

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }

        int randomIndex = random.Next(_prompts.Count);

        string selectedPrompt = _prompts[randomIndex];

        _prompts.RemoveAt(randomIndex);
        _usedPrompts.Add(selectedPrompt);

        return selectedPrompt;
    }

    public string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }

        int randomIndex = random.Next(_questions.Count);

        string selectedQuestion = _questions[randomIndex];

        _questions.RemoveAt(randomIndex);
        _usedQuestions.Add(selectedQuestion);

        return selectedQuestion;
    }
    
    public void DisplayPromt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"{question} ");
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Take a moment to reflect on the following promt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("Once you have something in mind, press enter to continue.");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            Console.WriteLine("Please press Enter to continue...");
        }

        Console.WriteLine("\nTake a few seconds to ponder the following questions and how they relate to this experience.");
        Console.Write("Begin your reflection in ");
        ShowCountDown(5);
        Console.Clear();
        _startTime = DateTime.Now;
        DateTime _endingTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endingTime)
        {
            DisplayQuestions();
            DisplaySpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
    
}