using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathe = new BreathingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        
        bool runProgram = true;
        Console.WriteLine("Welcome to the Mindfulness Program.");
        while (runProgram)
        {
            
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Enter the activity you would like to do (1-4): ");

            string activity = Console.ReadLine();

             switch (activity)
            {
                case "1":
                    do
                    {
                        breathe.Run();
                    }
                    while (breathe.RestartActivity());
                    breathe.ReturnToMenu();
                    break;
                case "2":
                    do
                    {
                        reflect.Run();
                    }
                    while (reflect.RestartActivity());
                    reflect.ReturnToMenu();
                    break;
                case "3":
                    do
                    {
                        listing.Run();
                    }
                    while (listing.RestartActivity());
                    listing.ReturnToMenu();
                    break;
                case "4":
                    runProgram = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Activity Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                    break;
            }
        }
    }
}