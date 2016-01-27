using System;

namespace WhileSchleife
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            SchleifeWirdEinmalAusgefuehrt();
            TrennerAusgeben();
            SchleifenrumpfWirdNichtAusgefuehrt();
            TrennerAusgeben();
            Break_SchleifeVorzeitigVerlassen();
            TrennerAusgeben();

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

            // ENDLOS-SCHLEIFE: wenn du diese Methode ausführen würdest, würde das Program nie
            // beendet werden. Du könntest es nur noch im Debugger oder über den TaskManager beenden!
            // Das liegt daran, dass die Bedingung immer TRUE ist, weil dort die entsprechende
            // Konstante verwendet wurde.
        }

        static void SchleifeWirdEinmalAusgefuehrt()
        {
            bool beenden = false;

            Console.WriteLine("Einmaliges Ausführen: while-Schleife wird gestartet!");
            while (!beenden)
            {
                Console.WriteLine("Die Bedingung wurde jetzt bereits einmal überprüft und hat TRUE ergeben.");

                beenden = true;
                // Der Schleifenkopf wird noch ein weiteres mal überprüft, aber der Schleifenrumpf
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

        static void Break_SchleifeVorzeitigVerlassen()
        {
            // Schlüsselwort: break

            // Die Hauptschleife eines Programmes wird manchmal als Endlosschleife realisiert.
            // Also beispielsweise mit while(true). Um nun das Programm trotzdem zu beenden,
            // oder wenn du dich das Ergebnis nicht mehr interessiert, kannst du break verwenden.
            // Damit wird der Schleifenrumpf sofort verlassen und die Bedingung nicht noch ein
            // weiteres mal überprüft.

            Console.WriteLine("Break: while-Schleife wird gestartet!");

            int zaehler = 0;
            while (true)
            {
                if (zaehler > 5)
                {
                    break;
                }

                zaehler = zaehler + 1;
                Console.WriteLine("Schleifenrumpf wird ausgeführt. Zaehler hat den Wert: {0}", zaehler);
            }
            Console.WriteLine("Schleife wurde abgebrochen, obwohl die Bedingung immer noch TRUE ist!");

            // HINWEIS: Die Verwendung von BREAK ist häufig sehr verwirrend. Daher solltest du dir
            // gut überlegen, ob du dies Schlüsselwort wirklich verwenden willst/musst. Es ist häufig
            // ein Zeichen, dass die Schleife falsch eingesetzt wird!
        }

        static void TrennerAusgeben()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
