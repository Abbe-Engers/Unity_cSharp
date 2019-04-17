using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "washi gekke kech";
            string guessedWord = "";
            int aantalguesses = 3;

            while (guessedWord != secretWord)
            {
                if (aantalguesses >= 1)
                {
                    Console.Write("Enter guess(" + aantalguesses + "): ");
                    guessedWord = Console.ReadLine();
                    aantalguesses = aantalguesses - 1;
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
