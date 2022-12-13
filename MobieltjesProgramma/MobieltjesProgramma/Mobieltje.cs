using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobieltjesProgramma
{
    public class Mobieltje
    {
        private float btw = 0.21f;
        private int verzendkosten = 30;
        public string type
        { get; private set; }
        public string model
        { get; private set; }
        public string os
        { get; private set; }
        public float prijs
        { get; private set; }
        public Mobieltje(string type, string model, string OS, float prijs)
        {
            this.type = type;
            this.model = model;
            this.os = OS;
            this.prijs = prijs;
        }
        public float BTW(int aantal)
        {
            if(aantal <= 3) { return aantal * prijs + ((aantal * prijs) * btw) + verzendkosten; }
            return aantal * prijs + ((aantal * prijs) * btw);
        }
        public string geefOprichter()
        {
            if(type == "Samsung")
            {
                return "Lee Byung-chull";
            }else if(type == "iPhone")
            {
                return "Steve Jobs";
            }else if(type == "Google Pixel")
            {
                return "Larr Page en Sergey Brin";
            }
            else
            {
                return "Onbekend type telefoon!";
            }
        }
    }
}
