using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Doctrine and Covenants", 121, 7, 8);
        Scripture scripture = new Scripture(reference, "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment; And then, if thou endure it well, God shall exalt thee on high; thou shalt triumph over all thy foes.");
        
        string input;
        Console.WriteLine("How many words do you want to hide at once? Pick between 1 and 3: ");
        
        while (true)
        {
            input = Console.ReadLine();
            if (int.Parse(input) >= 1 && int.Parse(input) <= 3)
            {
                break;
            }
            else{
                Console.WriteLine("Please enter 1, 2, or 3: ");
            }
        }
        
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress Enter to hide more words or type 'quit' to exit: ");

            string userInput = Console.ReadLine();
            if (userInput?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(int.Parse(input));
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}