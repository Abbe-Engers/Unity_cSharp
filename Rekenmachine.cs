using System;

namespace Helloworld
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Wat wilt u uitrekenen?(cijfer 1): ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wat wilt u uitrekenen?(cijfer 2): ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("wat wilt u met deze getallen doen?(X, /, -, +)");
            string rekenengap = Console.ReadLine();

            if (rekenengap == "X")
            {
                Console.Write(getal1 * getal2);
            }
            else if (rekenengap == "/")
            {
                Console.Write(getal1 / getal2);
            }
            else if (rekenengap == "-")
            {
                Console.Write(getal1 - getal2);
            }
            else if (rekenengap == "+")
            {
                Console.Write(getal1 + getal2);
            }
            else
            {
                Console.Write("kan het teken niet vinden, error 404");
            }

            Console.ReadLine();
        }
	}
}   
