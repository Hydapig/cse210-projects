public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private List<string> _usedPrompts = new List<string>();
    List<string> responses = new List<string>();
    protected Random random = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin in ");
        ShowCountDown(5);
        Console.WriteLine();
        
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            // responses.Add(Console.ReadLine());
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                responses.Add(userInput);
            }
            else
            {
                Console.Write("Please enter a response!");
            }
            
        }
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("\nGreat job answering the questions!!");

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

    // public List<string> GetListFromUser()
    // {
    //     return _prompts;
    // }
}