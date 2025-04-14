// using System.ComponentModel.Design;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){}

    public void AddPoints(int score)
    {
        _score += score;
    }
    public void Start()
    {
        Console.Clear();
        string menuSelection = "";
        string file;
        List<string> menuOptions = new List<string>{"Create New Goal","List Goals","Save Goals","Load Goals","Record Event","Quit"};
        while (menuSelection != "6")
        {
            
            Console.WriteLine("Welcome to your goal manager!");
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"  {i+1}. {menuOptions[i]}");
            }
            Console.Write("Select one of options from the menu: ");
            menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    Console.Write("Enter the file name you want to save to: ");
                    file = Console.ReadLine();
                    SaveGoals(file);
                    break;
                case "4":
                    Console.Write("Enter the file name you want to load: ");
                    file = Console.ReadLine();
                    LoadGoals(file);
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1-6");
                    break;

            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points");
    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            
            Console.WriteLine($"  {i++}. {goal.GetGoalName()}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nYou have not created any goals yet.");
            return;
        }
        Console.Clear();
        Console.WriteLine("Here is a list of your goals:");
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"  {i++}. {goal.GetDetailsString()}");
        }
        Thread.Sleep(1500);
    }

    public void CreateGoal()
    {
        Console.Clear();
        List<string> goalTypes = new List<string> {"Simple Goal","Eternal Goal","Checklist Goal"};
        Console.WriteLine("Here are the types of goals you can choose:");
        for (int i = 0; i < goalTypes.Count; i++)
            {
                Console.WriteLine($"  {i+1}. {goalTypes[i]}");
            }
        
        int choice;
        bool validInput = false;
        string goalMenuSelection = "";
        while (!validInput)
        {
            Console.Write("Which type of goal would you like to create? ");
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out choice))
            {
                if (choice >=1 && choice <= goalTypes.Count)
                {
                    goalMenuSelection = selection;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter one of the options above.");
                }
            }
            else
                {
                Console.WriteLine("Invalid input. Please enter a number.");   
                }
        }
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Please provide a short description of it: ");
        string description = Console.ReadLine();
        // Console.Write("How many points do you want to receive for completing this goal? ");
        int points;
        while (true)
        {
            Console.Write("How many points do you want to receive for completing this goal? ");
            if (int.TryParse(Console.ReadLine(), out points))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number for points.");
            }
        }
        
        switch (goalMenuSelection)
        {
            case "1":
                _goals.Add(new SimpleGoal(name,description,points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name,description,points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished to complete it?  ");
                int target;
                while (true)
                {
                    Console.Write("How many times does this goal need to be accomplished to complete it?  ");
                    if (int.TryParse(Console.ReadLine(), out target))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                
                int bonus;
                while (true)
                {
                    Console.Write("How many bonus points do you want for completing this goal? ");
                    if (int.TryParse(Console.ReadLine(), out bonus))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                
                _goals.Add(new ChecklistGoal(name,description,points,bonus,target));
                break;
        }
        if (_goals.Count == 1)
        {
            Console.WriteLine("Hurray! You created your first goal! Here's 100 points to celebrate");
            _score += 100;
        }
        else
        {
            Console.WriteLine("Your goal has been created!");
        }
        Thread.Sleep(1500);
        Console.Clear();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nYou have not created any goals yet.");
            return;
        }
        Console.WriteLine("\nYour current goals are:");
        ListGoalNames();
        
        while (true)
        {
            Console.Write("What goal did you work on? ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice >=1 && choice <= _goals.Count)
                {
                    _goals[choice -1].RecordEvent(this);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter one of the options above.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
        Thread.Sleep(5000);
        Console.Clear();
        
    }

    public void SaveGoals(string filename)
    {
        using var ouputFile = new StreamWriter(filename);
        ouputFile.WriteLine($"Score,{_score}");
        foreach (var goal in _goals)
        {
            ouputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine($"Your goals have been saved to the file {filename}");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            switch (parts[0])
            {
                case "Score":
                    _score = int.Parse(parts[1]);
                    break;
                
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1],parts[2],int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[6]),int.Parse(parts[5])));
                    break;
            }
        };
        Console.WriteLine($"Your goals have been loaded from {filename}");
        Thread.Sleep(2000);
        Console.Clear();
    }
}