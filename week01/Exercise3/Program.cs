using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        
        string play;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int guessNumber = -5;
            int guessCount = 0;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    guessCount = guessCount + 1;
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                    guessCount = guessCount + 1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessCount = guessCount + 1;
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            Console.Write("Would you like to play again? ");
            play = Console.ReadLine();
        } while (play == "yes");
    }
}