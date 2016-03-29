using System;

namespace SchlüsselwortStatic.StatischeKlassen
{
    public class Rechner
    {
        public int Resultat { get; private set; }
        public string LetzteBerechnung { get; private set; }

        public Rechner()
        {
            // Hier wird der Standardkonstruktor gesetzt um ein Objekt dieser Klasse
            // in einen definierten Zustand zu setzen.
            Resultat = 0;
            LetzteBerechnung = "Noch keine Berechnung ausgeführt";
        }

        public Rechner(int ausgangsWert) : this()
        {
            // Du verwendest einen Konstruktor mit Parametern, wenn du von außerhalb einen
            // Wert in das Objekt geben möchtest.
            // in der vorherigen Zeile gibt this() an, dass der Standardkonstruktor ERST
            // aufgerufen wird. Dies ist wichtig, weil ansonsten LetzteBerechnung nicht seinen
            // Initialwert bekäme, oder du hier die Zeile wiederholen müsstest.
            Resultat = ausgangsWert;
        }

        public int Addiere(int summand)
        {
            int letztesResultat = Resultat;

            // eigentliche Berechnung ausführen
            Resultat = Resultat + summand;

            // internen Zustand der Klasse konsistent halten
            // Die Außenwelt braucht nichts über die Abhängigkeiten dieser Methode zu
            // den Eigenschaften Resultat und LetzteBerechnung erfahren. Es passiert alles
            // in dieser Klasse. Es ist somit gekapselt und braucht nur an dieser Stelle
            // geändert werden, wenn sich etwas ändern soll.
            LetzteBerechnung = letztesResultat + " + " + summand + " = " + Resultat;

            return Resultat;
        }
    }
}
