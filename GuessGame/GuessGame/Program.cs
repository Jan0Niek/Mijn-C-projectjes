using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "informatica";
            string guessedWord = "";

            for(int i = 0; i< 3; i++)
            {
                if (guessedWord != secretWord)
                {
                    Console.Write("Enter guess: ");
                    guessedWord = Console.ReadLine();
                }
                if(guessedWord == secretWord) 
                {
                    Console.WriteLine("You've won!");
                    i = 3;
                }
            }
            if (guessedWord != secretWord)
            {
                Console.WriteLine("You've lost...");
            }
            

            Console.ReadLine();
        }
    }
}