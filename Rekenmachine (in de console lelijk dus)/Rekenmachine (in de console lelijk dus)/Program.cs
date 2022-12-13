using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in:");
            var getal1Input = Console.ReadLine();
            float getal1;
            //checkt of je een getal typte, zo niet, dan laat het je opnieuw typen totdat je het goed doet.
            while (float.TryParse(getal1Input,  out getal1) == false)
            {
                Console.WriteLine("Voer een getal in! ");
                getal1Input = Console.ReadLine();
            }

            Console.WriteLine("Voer een getal in:");
            var getal2Input = Console.ReadLine();
            float getal2;
            //checkt of je een getal typte, zo niet, dan laat het je opnieuw typen totdat je het goed doet.
            while (float.TryParse(getal2Input, out getal2) == false)
            {
                Console.WriteLine("Voer een getal in! ");
                getal2Input = Console.ReadLine();
            }

            Console.WriteLine("Voer een -, +, * of /-teken in:");
            float antwoord = 0.0f;
            string keuzeOperator = "nuh-uh";
            while (!(keuzeOperator == "-" || keuzeOperator == "+" || keuzeOperator == "*" || keuzeOperator == "/"))
            {
                keuzeOperator = Console.ReadLine();
                if (keuzeOperator == "-")
                {
                    antwoord = getal1 - getal2;
                }
                else if (keuzeOperator == "+")
                {
                    antwoord = getal1 + getal2;
                }
                else if (keuzeOperator == "*")
                {
                    antwoord = getal1 * getal2;
                }
                else if (keuzeOperator == "/" && getal2 != 0)
                {
                    antwoord = getal1 / getal2;
                }
                else
                {
                    Console.WriteLine("Voer een -, +, * of /-teken in!");
                }
            }
            if (keuzeOperator == "/" && getal2 == 0)
            {
                Console.WriteLine(getal1 + keuzeOperator + getal2 + " kan niet, want dat is delen door nul. ");
            }
            else
            {
                Console.WriteLine(getal1 + keuzeOperator + getal2 + " is gelijk aan " + antwoord);
            }
            Console.ReadLine();
        }
    }
}