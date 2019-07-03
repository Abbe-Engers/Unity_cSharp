using System;

namespace Helloworld
{
    class Program
    {
        const string secretWord = "sushi";

        static void Main(string[] args)
        {
            string guessedWord = "";
            int aantalGuesses = 3;

            while (guessedWord != secretWord)
            {
                if (aantalGuesses >= 1)
                {
                    Console.Write("Enter guess(" + aantalGuesses + "): ");
                    guessedWord = Console.ReadLine();
                    aantalGuesses = aantalGuesses - 1;
                }

                else
                {
                    Console.Write("Je hebt Verloren!");
                }
            }
            Console.WriteLine("You've won!");
            Console.ReadLine();
        }
    }
}
