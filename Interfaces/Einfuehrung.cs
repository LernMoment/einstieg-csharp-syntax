using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            List<string> namensListe = new List<string> { "hugo", "hermine", "henriette", "heinz" };
            string[] namensFeld = {"anna", "anton", "arielle", "alfonso"};

            Ausgabe("Liste", namensListe);
            Ausgabe("Feld", namensFeld);

            Console.ReadLine();
            Console.WriteLine("Zum beenden Enter drücken!");
        }

        static void Ausgabe(string typ, IEnumerable<string> aufzaehlung)
        {
            Console.WriteLine($"Ausgabe für den Typ: {typ}");

            foreach (var item in aufzaehlung)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
