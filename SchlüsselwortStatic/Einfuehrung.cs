using System;
using SchlüsselwortStatic.StatischeAttribute;

namespace SchlüsselwortStatic
{
    class Einfuehrung
    {
        // Das Schlüsselwort static wir hauptsächlich auf Klassen, Methoden und Attributen
        // angewendet. Dabei ist die Bedeutung bzw. die zugrunde liegende Idee bei der
        // Anwendung auf einer Methode und einem Attribut die gleiche. Wenn du static auf
        // einer Klasse anwendest, hat es eine etwas andere Bedeutung.

        // NON-STATIC ATTRIBUTE: Jedes Attribut einer Klasse, welches NICHT static deklariert
        // ist, wird pro Instanz einmal im Speicher angelegt. Dadurch ist dieses Attribut in jeder
        // Instanz autark. Solch ein Attribut kann in jeder Instanz einer Klasse einen 
        // unterschiedlichen Wert haben.
        private string fuerJedesObjektUnterschiedlich;

        // STATIC ATTRIBUTE: Ist ein Attribute in einer Klasse als static deklariert, wird es nur
        // genau einmal im Speicher abgelegt. Es ist also egal wie viele Instanz es von einer
        // Klasse gibt dieses Attribute mit seinem Wert gibt es nur genau einmal.
        // Dabei kann das Attribut von jeder Instanz verwendet und üblicherweise auch verändert
        // werden. Daher eignet es sich beispielsweise um einen Zähler für die Anzahl der bereits
        // angelegten Objekte (Instanzen) einer Klasse zuführen.
        // Aufbau:
        //         Schlüsselwort: static - bei Attributen immer vor dem Datentyp!!!
        //         |    Datentyp
        //         |    |        AttributName
        //         |    |        |
        private static int fuerAlleObjekteGleich; // Das ganze wird auch als Klassenattribut bezeichnet!

        //         Schlüsselwort: static - bei Methoden immer vor dem Datentyp des Rückgabewertes!!!
        //         |    Datentyp des Rückgabewertes
        //         |    |        MethodenName
        //         |    |        |
        private static void DarfNichtAufInstanzMemberZugreifen()
        {
            // In einer Methode die static deklariert ist, kann bzw. darf nicht auf Attribute bzw.
            // Methoden der Instanz zugegriffen werden.
        }

        static void Main(string[] args)
        {
            Console.WriteLine("BEISPIELE für statische Attribute:");
            Console.WriteLine();

            Console.WriteLine("Kraftwagen mit statischer Anzahl an Rädern:");
            ZeigeKraftwagenMitGleicherAnzahlBeispiel();
            TrennerAusgeben();

            Console.WriteLine("Instanzzähler - Beispiel für statische Attribute:");
            ZeigeInstanzZaehlerBeispiel();
            TrennerAusgeben();

            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }

        private static void ZeigeKraftwagenMitGleicherAnzahlBeispiel()
        {
            // ein static Attribut verändert sich für alle Objekte einer Klasse:
            KraftwagenMitGleicherAnzahlRaedern lkw = new KraftwagenMitGleicherAnzahlRaedern("40 Tonner");
            KraftwagenMitGleicherAnzahlRaedern smart = new KraftwagenMitGleicherAnzahlRaedern("Smart");
            smart.GibSteckbriefAus();
            // ein 40 Tonner sollte doch mehr als 4 Räder haben, oder?
            lkw.GibSteckbriefAus();
            lkw.SetzeAnzahlRaeder(16);
            lkw.GibSteckbriefAus();
            // hast du schon einen Smart mit 16 Rädern gesehen?
            smart.GibSteckbriefAus();
        }

        static void ZeigeInstanzZaehlerBeispiel()
        {
            // Am besten verstehst du was passiert, wenn du Schritt für Schritt durch den folgenden
            // Quellcode gehst und die anschaust, wie sich die Werte der Variablen verändern.
            Console.WriteLine("Zählen von Instanzen");

            string ersterName = "eins";
            InstanzZaehler eins = new InstanzZaehler(ersterName);
            eins.GibSteckbriefAus();

            string zweiterName = "zwei";
            InstanzZaehler zwei = new InstanzZaehler(zweiterName);
            // BEACHTE: hier wird wieder die Anzahl der Instanz von Objekt eins abgefragt!
            eins.GibSteckbriefAus();
        }

        static void TrennerAusgeben()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }

    }
}
