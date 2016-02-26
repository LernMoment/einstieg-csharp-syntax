using System;

namespace WhileSchleife
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            // Beschreibung(); -> Endlosschleife! Diese Methode nicht verwenden, sondern nur anschauen!

            SchleifeWirdEinmalAusgefuehrt();
            TrennerAusgeben();

            SchleifenrumpfWirdNichtAusgefuehrt();
            TrennerAusgeben();

            Break_SchleifeVorzeitigVerlassen();
            TrennerAusgeben();

            Return_VerlaesstAuchDieSchleife();
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

                // Hier können weitere Schlüsselworte verwendet werden:
                // return - Schleife (und Methode) sofort verlassen
                // break - Schleife sofort verlassen. Es wird nach dem Schleifenrumpf weiter gemacht.
                // continue - Iteration beenden. Als nächstes wird die Bedingung überprüft.
            }

            // ITERATION: Das einmalige Ausführen des Schleifenrumpfes wird als Iteration bezeichnet.
            // Bei der while-Schleife gibt es also sowohl Iterationen, bis die Bedingung nicht
            // mehr TRUE ist. Das bedeutet, dass es je nach Bedingung die Anzahl der möglichen
            // Iterationen zwischen 0 (Bedingung ist bei der ersten Überprüfung FALSE) und Unendlich
            // (Bedingung ist immer TRUE) liegt.

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
            Console.WriteLine("Schlüsselwort: break");

            // Die Hauptschleife eines Programmes wird manchmal als Endlosschleife realisiert.
            // Also beispielsweise mit while(true). Um nun das Programm trotzdem zu beenden,
            // oder wenn dich das Ergebnis nicht mehr interessiert, kannst du BREAK verwenden.
            // Damit wird der Schleifenrumpf sofort verlassen und die Bedingung nicht noch ein
            // weiteres mal überprüft.

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

        static void Return_VerlaesstAuchDieSchleife()
        {
            Console.WriteLine("Schlüsselwort: return");

            // Wenn du RETURN im Rumpf einer while-Schleife verwendest, wird nicht nur die Methode
            // verlassen, in der deine while-Schleife ist, sondern ebenfalls die Schleife.
            // Dabei wird der Schleifenrumpf sofort verlassen. Es wird also nicht nochmals die
            // Bedingung überprüft oder noch weitere Befehle im Schleifenrumpf ausgeführt.

            string befehl = "start";
            while (befehl.ToUpper() != "BEENDEN")
            {
                Console.Write("Gib beliebige Befehle ein: ");
                befehl = Console.ReadLine();

                if (befehl.ToUpper() == "RETURN")
                {
                    Console.WriteLine("Methode und Schleife werden jetzt sofort verlassen. Bedingung ist immer noch TRUE!");
                    return;
                }

                Console.WriteLine("Du hast mir folgenden Befehl gegeben: {0}", befehl);
                Console.WriteLine("Mit RETURN kannst du die Schleife abbrechen!");
                Console.WriteLine("Mit BEENDEN kannst du die Schleife normal beenden!");
            }
            Console.WriteLine("Du hast die Schleife normal beendet!");

            // HINWEIS: Auch die Verwendung von RETURN kann verwirrend sein, weil man es im Quell-
            // code schnell mal überlesen kann. Überlege lieber, ob du deine Schleife nicht so 
            // erstellen kannst, dass du return erst nach der Schleife verwendest!
        }

        static void TrennerAusgeben()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
