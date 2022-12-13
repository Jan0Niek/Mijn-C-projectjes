using System;

namespace Boodschappen
{
    class Program
    {
        const string product = "PONG";
        const float prijsExclBtw = 3.95f;


        const float btwPercentage = 0.21f;

        static void Main(string[] args)
        {
            int aantal;
            Console.WriteLine("Een pakje " + product + " kost " + prijsExclBtw + " ex btw. Met btw kost 1 pak: "+ (prijsExclBtw + (prijsExclBtw) * btwPercentage));
            Console.WriteLine("Voer een aantal in: ");
            var aantalKeuze = Console.ReadLine();
            //checkt of je een getal typte, zo niet, dan laat het je opnieuw typen totdat je het goed doet.
            while(int.TryParse(aantalKeuze, out _) == false)
            {
                Console.WriteLine("Voer een getal in! ");
                aantalKeuze = Console.ReadLine();
            }
            aantal = Convert.ToInt32(aantalKeuze);
            

            float totaalPrijs = btwBerekenen(aantal, prijsExclBtw);

            Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + totaalPrijs +". Zonder btw kost het " + (aantal* prijsExclBtw) +".");

            
            Console.ReadLine();
        }

        static float btwBerekenen(int aantal, float prijs)
        {
            return aantal * prijs + (aantal * prijs) * btwPercentage;

        }

    }
}