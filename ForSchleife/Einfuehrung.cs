using System;

namespace ForSchleife
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            // Beschreibung(); -> erklärt dir die Syntax, aber macht keine Ausgabe

            FeldDurchlaufen();
            TrennerAusgeben();

            ZaehlerAusserhalbDerSchleifeDefinieren();
            TrennerAusgeben();

            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }

        static void Beschreibung()
        {
            // Die for-Schleife verwendest du immer dann, wenn du einen Zähler brauchst.
            // Sie ist vom Aufbau her die komplexeste Schleife in C#. Seitdem es die foreach-
            // Schleife gibt, wird die for-Schleife nicht mehr ganz so häufig benutzt.
            // Das schön ist, dass du immer direkt weißt in welcher Iteration du dich gerade 
            // befindest, weil du im Schleifenrumpf auf den Zähler zugreifen kannst.

            // AUFBAU:

            // Schlüsselwort: for
            // |    Definition & Initialisierung des Zählers: Dieser Bereich ist optional
            // |    |       Bedingung: Schleifenrumpf wird ausgeführt bis Bedingung false ergibt
            // |    |       |      Iterator: Aktion hier wird nach jeder Iteration ausgeführt - Bereich ist optional
            for (int i = 0; i < 10; i++) // -> Schleifenkopf mit Schlüsselwort, Initialisierung, Bedingung, Iterator 
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

            // INITIALISIERUNG: Dieser Bereich der for-Schleife wird nur einmal zu Begin der Ausführung
            // der Schleife ausgeführt. Wenn du in diesem Bereich eine Variable definierst und initialiserst
            // wie oben dargestellt, ist diese Variable nur innerhalb der Schleife gültig und somit verfügbar.
            // D.h. du kannst nach der Schleife nicht mehr auf die Variable (in diesem Beispiel "i") zugreifen.
            // Möchtest du auch später noch auf die Variable zugreifen, dann kannst du vor der Schleife eine
            // Variable definieren und diese dann als Zähler verwenden. Dann kannst du trotzdem diese "externe"
            // Variable in der Schleife initialisieren (z.B. "for(meinZaehler = 0; meinZahler < 10; meinZaehler++)")
            // oder du lässt du hast deine Variable bereits ausserhalb der Schleife initialisiert und lässt
            // den Initialisierungsbereich dann ganz entfallen (z.B. "for(;meinZaehler < 10; meinZaehler++)").

            // BEDINGUNG: Die in diesem Bereich definiert Bedingung wird VOR jeder Iteration überprüft.
            // Wenn die Bedingung wahr ist, wird die Iteration (also der Schleifenrumpf) ausgeführt. 
            // Das gilt auch für die aller erste Iteration. Wenn die Bedingung also schon beim Einstieg 
            // in die Schleife nicht erfüllt ist, wird der Shcleifenrumpf nicht ein einzigesmal ausgeführt.

            // ITERATOR: Im Beispiel oben siehst du, dass der Zähler inkrementiert wird (also um eins erhöht).
            // Dies ist allerdings nicht verpflichtend. Du kannst genauso gut dekremnetieren (z.B. "i--")
            // oder eine beliebige andere Aktion ausführen (z.B. eine Methode aufrufen).
            // Wichtig ist, dass diese Aktion erst nach der jeweiligen Ausführung des Schleifenrumpfes ausge-
            // führt wird. Im Beispiel ob wird daher die Variable "i" in der ersten Iteration den Wert "0"
            // haben. Erst, wenn das erstemal der Schleifenrumpf durchlaufen wurde, wird "i" auf "1" erhöht.

            // while-Schleife mit for-Schleife: Auch wenn es eher unüblich ist, schreibt die Syntax nicht vor,
            // dass du einen Zähler verwenden MUSST. Du könntest also auch mit dem "for"-Schlüsselwort eine
            // while-Schleife realisieren (z.B. "for(; dasIstBloed != false;)"). Dies ist allerdings nicht
            // empfehlenswert, weil die for-Schleife ganz klar zum zählen gedacht ist.
        }

        static void FeldDurchlaufen()
        {
            // Die Grundidee für die for-Schleife kommt aus C/C++. Sie ist unter anderem sehr hilfreich
            // um Elemente in einem Feld zu durchlaufen.
            string[] feldMitVornamen = { "Heinz", "Hermine", "Hugo", "Helga" };

            for (int i = 0; i < feldMitVornamen.Length; i++)
            {
                // WICHTIG: Der Index für ein Feld beginnt bei 0 und nicht bei 1!!!
                // Daher wird der Zähler ("i") hier auf 0 initialisiert und die Bedingung
                // lautet kleiner als die Anzahl an Elementen im Feld. Der Ausdruck
                // "feldMitVornamen.Length" gibt in diesem Beispiel 4 zurück. Da wir aber auch das
                // erste Element (in diesem Fall "Heinz") ausgeben wollen, muss der Zähler ("i")
                // die Werte 0, 1, 2 und 3 annehmen, damit alle Elemente angesprochen werden.
                // Würde i den Wert 4 annehmen (z.B. mit der Bedingung "i <= feldMitVornamen.Length"),
                // gäbe es im 5. Durchlauf (i hat dann den Wert 4) einen Fehler, weil das Feld
                // dieses Element nicht besitzt.

                Console.WriteLine("Der {0}. Vorname ist: {1}", i, feldMitVornamen[i]);

                // In diesem Beispiel wird erst der aktuelle Wert des Zählers ausgegeben und
                // dann der Zähler verwendet um jedes Element in dem Feld "feldMitVornamen" auszugeben.
            }

            // ACHTUNG: i kann nach der Schleife in diesem Fall nicht benutzt werden, weil die Variable
            // nur innerhalb der Schleife definiert ist.
        }

        static void ZaehlerAusserhalbDerSchleifeDefinieren()
        {
            int zaehler = 10;

            // Auch wenn zaehler bereits initialisiert wurde, kannst du ihn für die Schleife
            // nochmals neu initialisieren (also eigentlich einfach nur einen anderen Wert 
            // zuweisen)
            for (zaehler = 0; zaehler < 10; zaehler++)
            {
                Console.WriteLine("Aktueller Wert des Zählers: {0}", zaehler);
            }

            // In diesem Fall kannst du nun zaehler auch nach der Schleife verwenden. Das ist
            // hilfreich, wenn du den Wert des Zählers später noch brauchst.
            // Bei der Verwendung musst du allerdings immer beachten wo du angefangen hast.
            // Obwohl in diesem Beispiel der zaehler bei 0 gestartet ist, hat er nach der Schleife
            // den Wert 10. Was den Verdacht nahe legt, dass die Schleife insgesamt 11 mal ausgeführt
            // wurde. Dieses ist jedoch nicht der Fall, weil nach der 10. Iteration der zaehler
            // nochmals inkrementiert wurde. Bei der darauf folgenden Überprüfung der Bedingung
            // für die 11. Iteration wurde allerdings festgestellt, dass die Bedingung jetzt nicht
            // mehr erfüllt ist und die Schleife wurde abgebrochen.
            Console.WriteLine("Die Schleife wurde {0} mal ausgeführt.", zaehler);
        }

        static void Continue_AktuellenDurchlaufAbbrechen()
        {
            // Das Schlüsselwort CONTINUE kannst du verwenden, wenn du den Rest des 
            // Schleifenrumpfs in dieser Iteration nicht durchlaufen willst.

            string[] feldMitVornamen = { "Heinz", "Hermine", "Hugo", "Helga" };

            for (int i = 0; i < feldMitVornamen.Length; i++)
            {
                // Wenn der Vorname Hugo ist, wollen wir den Rest dieser Iteration nicht mehr 
                // ausführen.
                // Dieser Vorname wird also nicht ausgegeben.
                // Anstelle dessen wird sofort wieder in den Schleifenkopf gesprungen.
                // Nach dem continue wird also der Zähler erhöht und dann die Bedingung
                // wieder überprüft.

                if (feldMitVornamen[i] == "Hugo")
                {
                    continue;
                }

                Console.WriteLine("Der {0}. Vorname ist: {1}", i, feldMitVornamen[i]);
            }

            // WICHTIG: continue bezieht sich nur auf die aktuelle Iteration! Es wird also
            // nicht wie bei break die Schleife komplett verlassen!
        }

        static void TrennerAusgeben()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
