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
        string menuSelection = "";
        List<string> menuOptions = new List<string>{"Create New Goal","List Goals","Save Goals","Load Goals","Record Event","Quit"};
        while (menuSelection != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"  {i++}. {menuOptions[i]}");
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
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
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
        foreach (var goal in _goals)
        {
            int i = 0;
            Console.WriteLine($"{i++}. {goal.GetGoalName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            int i = 0;
            Console.WriteLine($"{i++}. {goal.GetDetailsString}");
        }
    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {}

    public void SaveGoals()
    {}

    public void LoadGoals()
    {}
}