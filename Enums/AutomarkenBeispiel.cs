using System;

namespace Enums
{

    public class AutomarkenBeispiel
    {
        const int porsche = 1;
        const int audi = 2;

        public static void Ausfuehren()
        {
            GibAutoMarkeAus(porsche);
        }

        private static void GibAutoMarkeAus(int marke)
        {
            string ausgabe;

            switch (marke)
            {
                case porsche:
                    ausgabe = "Du fährst ein Auto der Marke: Porsche";
                    break;
                case audi:
                    ausgabe = "Du fährst ein Auto der Marke: Audi";
                    break;
                default:
                    ausgabe = "Deine Automarke kenne ich nicht";
                    break;
            }

            Console.WriteLine(ausgabe);
        }

        private static void Beschleunige(string autoMarke)
        {
            if (autoMarke == "Audi")
            {
                Console.WriteLine("Dein Audi beschleunigt so langsam auf 100km/h.");
            }
            else if (autoMarke == "Porsche")
            {
                Console.WriteLine("Dein Porsche rast auf 100km/h");
            }
            else
            {
                Console.WriteLine("Deine mir nicht bekannte Automarke wird auch irgendwann bei 100km/h sein.");
            }
        }
    }
}
