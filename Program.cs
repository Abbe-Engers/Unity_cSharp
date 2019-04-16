using System;

namespace Helloworld
{
	class Program
	{
		static void Main(string[] args)
		{
            string secretWord = "informatica";
            string guessedWord = "";

            while (guessedWord != secretWord)
            {
                Console.Write("Enter guess(" + aantalguesses + "): ");
                guessedWord = Console.ReadLine();
            }
            Console.WriteLine("You've won!");
            Console.ReadLine();
        }
	}
}   
