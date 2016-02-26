using System.Threading.Tasks;

namespace SchlüsselwortStatic
{
    // Siehe auch Erklärung hier: https://msdn.microsoft.com/de-de/library/79b3xss3.aspx

    public static class StatischeKlasse
    {
        // Statische Klassen können nicht instanziiert werden. Eine statische Klasse wird also
        // nie mit new verwendet. Anstelle dessen wird der Klassenname vor die zu verwendenden
        // Methoden, Attribute, Eigenschaften oder Events gestellt.

        // Eine statische Klasse fungiert als eine Art Container für eine Sammlung von ähnlichen
        // Methoden und Attributen die keine direkten Abhängigkeiten untereinander haben. D.h.
        // eine statische Klasse hat keinen internen Zustand der sich zwischen ihren Objekten
        // unterscheidet. 

        // Die Verwendung einer statischen Klasse bedeutet also, dass eher ein funktionales als
        // ein objektorientiertes Programmierkonzept verwendet wird (obwohl es sich um eine Klasse
        // handel!)

        // Typische Beispiele sind Konvertierungsfunktionen die alle Parameter direkt in die
        // Methode bekommen. Siehe TemperatureConverter Beispiel in
        // https://msdn.microsoft.com/de-de/library/79b3xss3.aspx und die statische Klasse
        // System.Math https://msdn.microsoft.com/de-de/library/system.math.aspx

        //       Schlüsselwort: static - muss bei jedem Member einer statischen Klasse verwendet werden!
        //       |
        public static string AddiereZeichenketten(string a, string b)
        {
            return a + b;
        }
    }
}
