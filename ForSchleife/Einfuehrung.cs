using System;

namespace ForSchleife
{
    class Einfuehrung
    {
        static void Main(string[] args)
        {
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
    }
}
