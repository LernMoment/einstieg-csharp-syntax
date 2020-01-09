using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Die grundlegende Idee eines Interface (oder Schnittstelle auf Deutsch) ist die Trennung
    // von Was und Wie. Ähm, okay, das ist jetzt vielleicht verwirrend ;-).
    // Eine Klasse drückt durch ihre Attribute, Eigenschaften und Methoden aus was sie tun kann.
    // Nimm als Beispiel die Methode "Ausgabe" weiter unten im Code. Schaust du dir nur den Methoden-
    // Kopf an, dann weißt du das sie 2 Parameter entgegen nimmt und anhand ihres Namens kannst
    // du vermuten, dass eine Ausgabe stattfinden soll. Das ist das WAS.
    // Wenn du dir den Methodenrumpf (also die eigentliche Implementierung) anschaut, dann weißt
    // du das diese Methode eine Ausgabe auf der Console macht. D.h. die Implementierung 
    // beschreibt WIE die Methode genau funktioniert.
    // Natürlich gibt es viele verschiedene Möglichkeiten wie eine Ausgabe gemacht werden kann.
    // So könnte z.B. die Ausgabe auch über ein Netzwerk, eine RS232 Verbindung, den Lautsprecher
    // oder ein Fenster erfolgen.
    // Während eine Klasse (in den meisten Fällen) das WAS und das WIE beschreibt, ist in einem
    // Interface immer nur das WAS beschrieben. D.h. ein Interface besteht aus Methodenköpfen
    // und/oder Eigenschaften (ohne Implementierung). Siehe das Interface IBeispiel als Beispiel ;-).
    public interface IBeispiel
    {
        int EigenschaftImInterface { get; set; }
        void MethodeImInterface(int ersterParameter, string zweiterParameter);
    }

    // Die Anwendungsszenarien für Interfaces sind sehr unterschieldlich. Aber etwas das du
    // wahrscheinlich schon häufiger benutzt hast ist die foreach Schleife. Die foreach
    // läuft über alle Elemente einer Auflistung. Da es nun ziemlich viele verschiedene 
    // Auflistungen gibt, müsste sie quasi für jede Auflistung (z.B. Array, Liste, Dictionary,
    // ...) eine eigene Implementierung haben.
    // Das ist wenig produktiv und daher implementiert jede Aufzaehlung das Interface 
    // IEnumerable<T>. 
    // https://docs.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerable-1?view=netframework-4.8
    // Das einzige was dieses Interface definiert ist die Methode GetEnumerator. Diese
    // wiederum gibt ein weiteres Interface IEnumerator<T> zurück. Damit ist es möglich
    // sich das aktuelle Element einer verbundenen Auflistung zuholen ("Current") und dann zusagen,
    // dass das nächste Element in der Auflistung angesprungen werden soll ("MoveNext").
    // https://docs.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerator-1?view=netframework-4.8
    // Damit die foreach Schleife nun funktioniert braucht sie nichts anderes als diese beiden
    // Interfaces. Damit kann sie alles umsetzen was sie benötigt. Wie genau sie nun den
    // Enumerator bekommt und wie dieser genau dieser funktioniert interessiert die foreach
    // Schleife nicht die Bohne.
    // Das WIE ist Abhängig von der jeweiligen Auflistung. Daher implementieren alle Auflistungen
    // die die foreach Schleife unterstützen wollen diese beiden Interfaces. D.h. Sie stellen
    // einen eigenen Enumerator bereit der weiß wie in der jeweiligen Auflistung von einem
    // element zum nächsten gesprungen werden kann. Außerdem stellen sie über die 
    // GetEnumerator Methode genau diesen Enumerator zur Verfügung, wenn die foreach Schleife
    // sie danach fragt.
    // Das coole dabei ist, dass die foreach überhaupt nicht weiß bzw. wissen muss auf welcher
    // konkreten Datenstruktur sie nun arbeitet. D.h. du hast Datenkapselung par excellence!
    // https://www.lernmoment.de/alle/was-ist-datenkapselung/
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            // Wir legen hier sowohl eine Liste wie auch ein Array (Feld) an. So können wir bisher
            // noch nicht sehen, dass diese beiden Klassen das Interface IEnumerable<T> implementieren.
            List<string> namensListe = new List<string> { "hugo", "hermine", "henriette", "heinz" };
            string[] namensFeld = {"anna", "anton", "arielle", "alfonso"};

            // Daher habe ich weiter unter die Methode Ausgabe angelegt der nur das Interface
            // IEnumerable<T> übergeben werden kann. Würdest du beispielweise versuchen einfach
            // einen string oder ein int anstelle von namensListe zu übergeben, dann gibt es einen Fehler.
            Ausgabe("Liste", namensListe);
            Ausgabe("Feld", namensFeld);

            Console.ReadLine();
            Console.WriteLine("Zum beenden Enter drücken!");
        }

        // Ab hier ist nun ganz egal welche Auflistung wir bekommen. Wir arbeiten nur noch auf dem
        // übergebenen Interface.
        // WICHTIG: Wir können nun natürlich auch keine Funktionalität Aufrufen die die Auflistung
        // hat die wir übergeben. D.h. in dieser Methode steht nur ein winzig kleiner Teil der
        // verfügbaren Funktionalität des übergebenen Objektes zur Verfügung. Hinter dem Parameter
        // "aufzaehlung" steckt zur Laufzeit nämlich immer noch das jeweilige Objekt.
        // In unserem Beispiel also entweder "namensListe" oder "namensFeld". 
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
