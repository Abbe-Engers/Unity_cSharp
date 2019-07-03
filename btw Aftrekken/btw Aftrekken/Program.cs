using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btw_Aftrekken
{
    class Program
    {
        static int Percentage = 100;

        static void Main(string[] args)
        {
            Console.Write("Over hoeveel euro wil je belasting betalen?: ");
            string aantalEuro = Console.ReadLine();
            int aantalEuroInt = Convert.ToInt32(aantalEuro);

            Product GeenLuxe = new Product(6);
            Console.WriteLine(" ");
            Console.WriteLine("##########Geen-luxe##########");
            Console.WriteLine(" ");
            belastingBon(aantalEuroInt, GeenLuxe.BTWPercentage);
            Console.WriteLine(" ");
            Console.WriteLine("#############################");



            Product WelLuxe = new Product(21);
            Console.WriteLine(" ");
            Console.WriteLine("#######Wel-luxe##############h");
            Console.WriteLine(" ");
            belastingBon(aantalEuroInt, WelLuxe.BTWPercentage);
            Console.WriteLine(" ");
            Console.WriteLine("#############################");
            Console.ReadLine();
        }

        public static void belastingBon(int euro, int BTW)
        {
            int factorInt = Percentage / BTW;
            int belastingInt = euro / factorInt;
            int overigGeld = euro - belastingInt;
            Console.WriteLine("Aantal BTW: " + belastingInt);
            Console.WriteLine("");
            Console.WriteLine("Aantal Euro na BTW betaling: " + overigGeld);
        }
    
    }
}
