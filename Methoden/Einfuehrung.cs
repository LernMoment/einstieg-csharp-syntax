using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    /// <summary>
    /// Zeigt dir die wichtigsten Grundlagen (insbesondere Begriffe) rund um das
    /// Thema Methoden. Außerdem werden von hier alle Beispiele zum Thema Methoden
    /// aufgerufen.
    /// </summary>
    class Einfuehrung
    {
        // Bei der Definition einer Methode (auch Methodendefinition genannt) geht es darum,
        // das du den Quellcode schreibst der sagt was zutun ist, wenn diese Methode ausgeführt
        // wird. 
        // Aufbau:
        // Zugriffsmodifizierer
        //  |
        //  |   Datentyp des Rückgabewerts
        //  |    |
        //  |    |               Methodenname in CamelCase-Notation
        //  |    |                   |
        //  |    |                   |                            Datentyp vom ersten Parameter
        //  |    |                   |                             |
        //  |    |                   |                             |      Name des ersten Parameters
        //  |    |                   |                             |        |
        public void MethodeOhneRueckgabewertAberMitEinemParameter(int parameterName) // <- Methodenkopf
        {
            // Dies ist der Methodenrumpf. Er beginnt mit einer geöffneten geschweiften Klammer
            // und muss mit einer geschlossenen geschweiften Klammer beendet werden.
            throw new NotImplementedException("Methode ist nur als Beispiel gedacht!");

            // Nur wenn die Methode keinen Wert zurück gibt (also der Datentyp des Rückgabewertes
            // void ist), kann auf das "return" am Ende der Methode verzichtet werden.
        }

        static void Main(string[] args)
        {
        }

    }
}
