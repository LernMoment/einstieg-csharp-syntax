using System;

namespace Enums
{
    public enum AutoMarke
    {
        porsche,
        audi
    }

    public class AutomarkenBeispiel
    {
        const int porsche = 1;
        const int audi = 2;

        public static void Ausfuehren()
        {
            AutoMarke meinAuto = AutoMarke.audi;

            GibAutoMarkeAus(meinAuto);

            Console.WriteLine("Die Marke meines Autos: " + meinAuto.ToString());
        }

        private static void GibAutoMarkeAus(AutoMarke marke)
        {
            string ausgabe;

            switch (marke)
            {
                case AutoMarke.porsche:
                    ausgabe = "Du fährst ein Auto der Marke: Porsche";
                    break;
                case AutoMarke.audi:
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
