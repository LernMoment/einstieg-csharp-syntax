using System;

namespace WhileSchleife
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            SchleifeWirdEinmalAusgefuehrt();
            SchleifenrumpfWirdNichtAusgefuehrt();

            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }

        static void Beschreibung()
        {
            // Die while-Schleife ist die einfachste der in C# zur Verfügung stehenden Schleifen.
            // Der Inhalt des Schleifenrumpfes wird solange wiederholt, wie die Bedingung erfüllt
            // ist (wahr ist).

            // AUFBAU:

            // Schlüsselwort: while
            // |    Bedingung: Schleifenrumpf wird ausgeführt bis Bedingung false ergibt
            // |    |
            while (true) // -> Schleifenkopf mit Schlüsselwort und Bedingung
            // Nun kommt der Schleifenrumpf mit den üblichen geschweiften Klammern
            {
                // Alles zwischen diesen Klammern wird solange wiederholt, bis die Bedingung nicht
                // mehr erfüllt ist. Dabei wird die Bedingung VOR jeder Ausführung des 
                // Schleifenrumpfs abgefragt.
            }
        }

        static void SchleifeWirdEinmalAusgefuehrt()
        {
            bool beenden = false;

            Console.WriteLine("Einmaliges Ausführen: while-Schleife wird gestartet!");
            while (!beenden)
            {
                Console.WriteLine("Die Bedingung wurde jetzt bereits einmal überprüft und hat TRUE ergeben.");

                beenden = true;
                // Der Schleifenkopf wird noch ein weiteresmal überprüft, aber der Schleifenrumpf
                // nicht nochmals ausgeführt, weil die Bedingung nun FALSE ergibt.
            }
            Console.WriteLine("while-Schleife wurde verlassen!");
        }

        static void SchleifenrumpfWirdNichtAusgefuehrt()
        {
            bool beenden = false;

            Console.WriteLine("Nicht Ausführen: while-Schleife wird gestartet!");
            // Durch das Entfernen des ! ergibt die erste Überprüfung der Bedingung: FALSE
            // Somit wird der Schleifenrumpf erst gar nicht ausgeführt.
            while (beenden)
            {
                Console.WriteLine("Dieser Text wird nie ausgegeben!");
            }
            Console.WriteLine("while-Schleife wurde verlassen!");
        }
    }
}
