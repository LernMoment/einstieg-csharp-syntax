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
            int[,] tabelle = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int spaltenIndex = 0; spaltenIndex < 3; spaltenIndex++)
            {
                for (int zeilenIndex = 0; zeilenIndex < 3; zeilenIndex++)
                {
                    Console.WriteLine($"Spalte: {spaltenIndex}, Zeile: {zeilenIndex}, Inhalt: {tabelle[spaltenIndex, zeilenIndex]}");
                }
            }

            Console.WriteLine("Zum beenden bitte RETURN drücken!");
            Console.ReadLine();
        }
    }
}
