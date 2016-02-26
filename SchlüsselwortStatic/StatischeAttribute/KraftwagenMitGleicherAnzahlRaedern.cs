using System;

namespace SchlüsselwortStatic
{
    public class KraftwagenMitGleicherAnzahlRaedern
    {
        // dadurch, dass die anzahlRaeder als static definiert ist, ändert sich 
        private static int anzahlRaeder = 4;

        public KraftwagenMitGleicherAnzahlRaedern(string typ)
        {
            Typ = typ;
        }

        public string Typ { get; private set; }

        public void GibSteckbriefAus()
        {
            Console.WriteLine("Kraftwagen vom Typ: {0}", Typ);
            Console.WriteLine("Anzahl Räder: {0}", anzahlRaeder);
        }

        public void SetzeAnzahlRaeder(int anzahl)
        {
            anzahlRaeder = anzahl;
        }
    }
}
