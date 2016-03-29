using System;
using SchlüsselwortStatic.StatischeAttribute;
using SchlüsselwortStatic.StatischeMethode;

namespace SchlüsselwortStatic
{
    /// <summary>
    /// Zeigt anhand von konkreten Beispielen wie das Schlüsselwort static verwendet werden kann.
    /// Die wichtigsten Informationen sind als Kommentare im Quellcode enthalten.
    /// </summary>
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
        // Daher wird bei einem non-static Attribute auch von einer Instanzvariablen gesprochen.
        private string fuerJedesObjektUnterschiedlich;

        // STATIC ATTRIBUTE: Ist ein Attribute in einer Klasse als static deklariert, wird es nur
        // genau einmal im Speicher abgelegt. Es ist also egal wie viele Instanz es von einer
        // Klasse gibt dieses Attribute mit seinem Wert gibt es nur genau einmal.
        // Dabei kann das Attribut von jeder Instanz verwendet und üblicherweise auch verändert
        // werden. Daher eignet es sich beispielsweise um einen Zähler für die Anzahl der bereits
        // angelegten Objekte (Instanzen) einer Klasse zuführen.
        // Dementsprechend wird ein Attribut, welches static definiert ist auch Klassenvariable genannt.
        // Aufbau:
        //         Schlüsselwort: static - bei Attributen immer vor dem Datentyp!!!
        //         |    Datentyp
        //         |    |        AttributName
        //         |    |        |
        private static int fuerAlleObjekteGleich; // Das ganze wird auch als Klassenattribut bezeichnet!

        // STATIC METHOD: Ist eine Methode in einer Klasse als static deklariert, kann diese Methode
        // nur auf Klassenvariablen und weitere Klassenmethoden zugreifen. Solche ein Methode kann
        // also keine Instanzvariablen verändern.
        // Diese Methoden eignen sich besonders um Objekte einer Klasse anzulegen (z.B. Factorymethode)
        // oder Hilfsmethoden (z.B. Konvertierungsfunktionen) bereitzustellen. Die Klasse Math besteht
        // beispielsweise nur aus statischen Methoden.
        // Eine static Methode wird auch als Klassenmethode bezeichnet.
        //         Schlüsselwort: static - bei Methoden immer vor dem Datentyp des Rückgabewertes!!!
        //         |    Datentyp des Rückgabewertes
        //         |    |        MethodenName
        //         |    |        |
        private static void DarfNichtAufInstanzMemberZugreifen()
        {
            // In einer Methode die static deklariert ist, kann bzw. darf nicht auf Attribute bzw.
            // Methoden der Instanz zugegriffen werden.

            // Es ist also nicht möglich folgende Zeile zu schreiben. Probier es aus und entferne die
            // Kommentarzeichen an der nächsten Zeile
            // fuerJedesObjektUnterschiedlich = "Geht hier einfach nicht!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("BEISPIELE für statische Attribute:");
            Console.WriteLine();

            Console.WriteLine("Kraftwagen mit statischer Anzahl an Rädern:");
            StatischesAttribut_KraftwagenMitGleicherAnzahlRaedern();
            TrennerAusgeben();

            Console.WriteLine("Instanzzähler - Beispiel für statische Attribute:");
            StatischesAttribute_InstanzZaehlerBeispiel();
            TrennerAusgeben();

            Console.WriteLine("Statischer Rechner - Beispiel für statische Methode:");
            StatischeMethode_StatischerRechner();
            TrennerAusgeben();

            Console.WriteLine("Statischer Rechner - Beispiel für nicht statische Methode:");
            StatischeMethode_EinfacherNichtStatischerRechner();
            TrennerAusgeben();

            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }

        private static void StatischeMethode_EinfacherNichtStatischerRechner()
        {
            // anlegen der benötigten Variablen und Initialisierung
            int ersteZahl = 10;
            int zweiteZahl = 15;

            // Die eigentliche Berechnung jetzt in der objektorientierten Art
            Rechner rechner = new Rechner(ersteZahl);
            rechner.Addiere(zweiteZahl);

            // Im Gegensatz zum statischen Rechner können wir von dem objektorientierten
            // einfach eine weitere Instanz bzw. ein Objekt anlegen. Mit diesem kannst du
            // komplett unabhängig von der ersten Berechnung arbeiten.
            Rechner weitererRechner = new Rechner(20);
            weitererRechner.Addiere(22);

            Console.WriteLine("Das Objekt rechner hat die Berechnung {0} ausgeführt", rechner.LetzteBerechnung);
            Console.WriteLine("Das Objekt weitererRechner hat die Berechnung {0} ausgeführt", weitererRechner.LetzteBerechnung);
        }

        private static void StatischeMethode_StatischerRechner()
        {
            int ersteZahl = 10;
            int zweiteZahl = 15;
            int resultat = 0;

            // verwendet die statische Methode an der Klasse Rechner.
            resultat = Rechner.Addieren(ersteZahl, zweiteZahl);

            Console.WriteLine("Das Resultat der statsischen Berechnung von {0} + {1} ist {2}", ersteZahl, zweiteZahl, resultat);
        }

        private static void StatischesAttribut_KraftwagenMitGleicherAnzahlRaedern()
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

        static void StatischesAttribute_InstanzZaehlerBeispiel()
        {
            // Am besten verstehst du was passiert, wenn du Schritt für Schritt durch den folgenden
            // Quellcode gehst und dir anschaust, wie sich die Werte der Variablen verändern.
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
