using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long aantalfibonaccis = 92;

            long[] fibonacci = new long[aantalfibonaccis];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (long i = 2; i < aantalfibonaccis; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                fibonacci[i] = (fibonacci[i - 1]) + (fibonacci[i - 2]);
                Console.WriteLine(fibonacci[i]);
            }

            Console.ReadLine();
        }
    }
}
