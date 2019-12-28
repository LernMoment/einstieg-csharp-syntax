using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZweiDimensionalesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zwei-Dimensionales Array (3x3 - wie Telefontastatur)");

            // Ein 2d-Array kann auf verschiedene Art und Weise angelegt werden. Hier die Variante, wenn
            // du das Array mit bekannten Zahlen initialisieren willst.
            int[,] tabelle = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Um das Array komplett zu durchlaufen benötigst du 2 Indezes. Mit dem einen gehst du durch die 
            // Spalten und mit dem anderen durch die Zeilen:
            for (int spaltenIndex = 0; spaltenIndex < 3; spaltenIndex++)
            {
                for (int zeilenIndex = 0; zeilenIndex < 3; zeilenIndex++)
                {
                    Console.WriteLine($"Spalte: {spaltenIndex}, Zeile: {zeilenIndex}, Inhalt: {tabelle[spaltenIndex, zeilenIndex]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Einzelne Zellen in der Tabelle ändern:");
            // Möchtest du den Inhalt verändern, dann kannst du unter Angabe von Spalte und Zeile sagen welche
            // Zelle in der Tabelle verändert werden soll. So ersetzt du z.B. 3 -> 10, 5 -> 11, 7 -> 12
            tabelle[0, 2] = 10;
            tabelle[1, 1] = 11;
            tabelle[2, 0] = 12;
            for (int spaltenIndex = 0; spaltenIndex < 3; spaltenIndex++)
            {
                for (int zeilenIndex = 0; zeilenIndex < 3; zeilenIndex++)
                {
                    Console.WriteLine($"Spalte: {spaltenIndex}, Zeile: {zeilenIndex}, Inhalt: {tabelle[spaltenIndex, zeilenIndex]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ein zweidimensionales Array ist ein Array von Arrays:");
            // Du suchst also im Array über den ersten Index eines der darin gespeicherten Arrays aus.
            // In diesem Beispiel haben wir ein Array von 3 Arrays. Möchtest du auf das mittlere Array
            // zugreifen geht das so:
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Bitte gib eine Zahl ein: ");
                tabelle[1, i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Das Array sieht nach deiner Änderung nun so aus:");
            for (int spaltenIndex = 0; spaltenIndex < 3; spaltenIndex++)
            {
                for (int zeilenIndex = 0; zeilenIndex < 3; zeilenIndex++)
                {
                    Console.WriteLine($"Spalte: {spaltenIndex}, Zeile: {zeilenIndex}, Inhalt: {tabelle[spaltenIndex, zeilenIndex]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }
    }
}
