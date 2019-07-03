using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btw_Aftrekken
{
    class Program
    {
        static int percentage = 100;

        static void Main(string[] args)
        {
            Console.Write("Over hoeveel euro wil je belasting betalen?: ");
            string aantalEuro = Console.ReadLine();
            int aantalEuroInt = Convert.ToInt32(aantalEuro);

            Mobiel GeenLuxe = new Mobiel(6, "SE", "Iphone", "Apple", "IOS");
            Console.WriteLine(" ");
            Console.WriteLine("##########Geen-luxe##########");
            Console.WriteLine(" ");
            belastingBon(aantalEuroInt, GeenLuxe.GetBTWPercentage());
            Console.WriteLine(" ");
            Console.WriteLine("#############################");



            Mobiel WelLuxe = new Mobiel(21, "A3", "Galaxy", "Samsung", "Android");
            Console.WriteLine(" ");
            Console.WriteLine("#######Wel-luxe##############h");
            Console.WriteLine(" ");
            belastingBon(aantalEuroInt, GeenLuxe.GetBTWPercentage());
            Console.WriteLine(" ");
            Console.WriteLine("#############################");
            Console.ReadLine();
        }

        public static void belastingBon(int euro, int BTW)
        {
            int factorInt = percentage / BTW;
            int belastingInt = euro / factorInt;
            int overigGeld = euro - belastingInt;
            Console.WriteLine("Aantal BTW: " + belastingInt);
            Console.WriteLine("");
            Console.WriteLine("Aantal Euro na BTW betaling: " + overigGeld);
        }
    
    }
}
