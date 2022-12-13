using MobieltjesProgramma;
using System;

namespace MobieltjesWinkel
{
    class Program
    {

        static void Main(string[] args)
        {
            Mobieltje iphone = new Mobieltje("iPhone", "iPhone XS", "Apple IOS", 999f);
            Mobieltje samsung = new Mobieltje("Samsung", "Galaxy S7", "Android", 390f);
            Mobieltje pixel = new Mobieltje("Google Pixel", "Pixel 3", "Android", 400f);

            Console.WriteLine("Welkom bij onze winkel, we verkopen hier een " + iphone.model + ", een " + samsung.model + ", en een " + pixel.model + ".");
            Console.WriteLine("Een " + iphone.model + " kost " + iphone.prijs + " zonder BTW en " + iphone.BTW(1) + " met BTW.");
            Console.WriteLine("Een " + samsung.model + " kost " + samsung.prijs + " zonder BTW en " + samsung.BTW(1) + " met BTW.");
            Console.WriteLine("Een " + pixel.model + " kost " + pixel.prijs + " zonder BTW en " + pixel.BTW(1) + " met BTW.");

            Console.WriteLine("Typ welk type je wilt kopen: ");
            string keuze = Console.ReadLine();
            while(!(keuze==iphone.model) && (keuze==samsung.model) && (keuze == pixel.model))
            {
                Console.WriteLine("Een typfout, welke type telefoon wil je?");
                keuze = Console.ReadLine();
            }

            Console.WriteLine("Hoeveel van die telefoons wil je kopen?");
            Console.WriteLine("Vanaf 3 telefoons gratis verzendkosten! Dan bespaar je een hele 30 euro's!");
            var aantalKeuze = Console.ReadLine();
            int aantal;
            while (int.TryParse(aantalKeuze, out aantal) == false)
            {
                Console.WriteLine("Geen geheel getal gevonden, hoeveel telefoons nou?");
                aantalKeuze = Console.ReadLine();
            }

            if(keuze == iphone.model) 
            {
                Console.WriteLine(aantal + " " + iphone.model + "'s kosten " + iphone.BTW(aantal) + " euro met BTW en eventuele verzendkosten.");
                Console.WriteLine("Wist je dat de oprichter van het bedrijf achter jouw telefoon " + iphone.geefOprichter() + " is?");
            }
            else if(keuze == samsung.model)
            {
                Console.WriteLine(aantal + " " + samsung.model + "'s kosten " + samsung.BTW(aantal) + " euro met BTW en eventuele verzendkosten.");
                Console.WriteLine("Wist je dat de oprichter van het bedrijf achter jouw telefoon " + samsung.geefOprichter() + " is?");
            }
            else if(keuze == pixel.model)
            {
                Console.WriteLine(aantal + " " + pixel.model + "'s kosten " + pixel.BTW(aantal) + " euro met BTW en eventuele verzendkosten.");
                Console.WriteLine("Wist je dat de oprichters van het bedrijf achter jouw telefoon " + pixel.geefOprichter()+" zijn?");
            }

            Console.ReadLine();
        }
    }
}