using System;

namespace Enums
{
    /// </summary>
    // Eine Enum (kurz für Enumeration) ist eine Menge von Wert-Bezeichner-Paaren (Konstanten).
    // Eine Enum bekommt bei der Definition einen Namen, welcher dann wie beispielsweise ein
    // Klassenname beim Anlegen von Variablen verwendet werden kann.
    // Wenn du eine Enum definierst, erstellst du somit einen neuen Datentypen. Dieser Datentyp
    // ist eigentlich nichts weiter als ein ganzzahliger Wert mit fest definierten Werten. 
    // Im folgenden ein kurzer Überblick über die Bestandteile einer ENUM:

    // ZUGRIFFSMODIFIZIERER (access modifier): Ist bei Enums meistens public.
    // Sofern die Enum im Namespace (Standardfall) und nicht in einer Klasse (Spezialfall)
    // definiert ist, muss der Zugriffsmodifizier public sein!
    // Details siehe MSDN
    // https://msdn.microsoft.com/de-de/library/ms173121.aspx#Anchor_2

    // NAME: Der Name einer Enum sollte im Pascal-Case-Stil sein, nicht das Wort Enum beinhalten
    // und überlicherweise Singular sein. https://msdn.microsoft.com/de-de/library/4x252001(v=vs.71).aspx
    // D.h. der Name sollte mit einem Großbuchstaben beginnen und alle weiteren Worte sollten 
    // ebenfalls durch einen Großbuchstaben makiert sein.

    // Aufbau:
    // Zugriffsmodifizierer (engl.: access modifier or method visibility)
    //  |
    //  |   Schlüsselwort enum
    //  |    |
    //  |    |          Name der Enum in Pascal-Case-Notation und Singular
    //  |    |              |
    //  |    |              |
    public enum PersoenlicheSchwaeche
    {
        Keine,
        Unkommunikativ,
        EsseZuvielSuessigkeiten
    }

    /// <summary>
    /// Zeigt dir die wichtigsten Grundlagen (insbesondere Begriffe) rund um das
    /// Thema Enums. Außerdem werden von hier alle Beispiele zum Thema Enums
    /// aufgerufen.
    class Einfuehrung
    {
        static void Main(string[] args)
        {
            // Eine Variable vom typ deines Enums wird so angelegt:
            PersoenlicheSchwaeche meineSchwaeche;

            // Dieser Variablen kannst du nun alle gültigen Werte aus der Enum zuweisen.
            meineSchwaeche = PersoenlicheSchwaeche.EsseZuvielSuessigkeiten;

            // Eine Variable von einem Enum-Typ kannst du verwenden wie jede andere Variable auch:
            if (meineSchwaeche == PersoenlicheSchwaeche.EsseZuvielSuessigkeiten)
            {
                Console.WriteLine("Weisheit des Tages: Du vergiftest deinen Körper!");
            }

            AutomarkenBeispiel.Ausfuehren();

            Console.ReadLine();
        }
    }
}
