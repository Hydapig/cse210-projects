using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the Journal Program.");

        bool quit = false;
        PromptGenorator prompt = new PromptGenorator();
        
        Journal journal = new Journal();
        

        while (!quit)
        {
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                string randomPrompt = prompt.GetRandomPrompt();
                Console.Write("");
                Console.WriteLine(randomPrompt);
                string text = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("dd/MM/yyyy");
                entry._promptText = randomPrompt;
                entry._entryText = text;

                journal._entries.Add(entry);
            }
            else if (input == "2")
            {
                Console.WriteLine("");
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.WriteLine("Please enter a file name: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Your journal has been saved.");
                Console.WriteLine("");
            }
            else if (input == "4")
            {
                Console.WriteLine("Enter a file name: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Your journal has been uploaded...");
            }
            else if (input == "5")
            {
                Console.WriteLine("Thank you for writing in your journal today!");
                quit = true;
            }
            else{
                Console.WriteLine("Please enter a valid choice");
            }
        }
    }
}