using System;

namespace SchlüsselwortStatic.StatischeAttribute
{
    public class InstanzZaehler
    {
        public static int Zaehler { get; private set; } = 0;

        private string name;

        public InstanzZaehler(string einName)
        {
            Zaehler++;
            this.name = einName;
        }

        public int GibAnzahlErzeugterInstanzen()
        {
            // ACHTUNG: In diesem Beispiel wird wirklich nur gezählt, wie häufig ein Objekt der
            // Klasse angelegt wurde. Es sagt nichts darüber aus wie viele aktuell existieren!!!
            // Einige der angelegten Instanzen können bereits schon wieder gelöscht sein.
            return Zaehler;
        }

        public void GibSteckbriefAus()
        {
            Console.WriteLine("Anzahl angelegter Instanzen: {0}", Zaehler);
            Console.WriteLine("Name dieser Instanz: {0}", name);
        }
    }
}
