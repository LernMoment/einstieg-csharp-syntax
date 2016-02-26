using System;

namespace WhileSchleife
{
    public class Echo
    {
        public static void Ausfuehren()
        {
            string eingabe = "";
            Console.WriteLine("Du wirst ein Echo sehen ;-)! Zum beenden ENDE eingeben.");

            while (eingabe.ToLower() != "ende")
            {
                Console.Write("Sag etwas: ");
                eingabe = Console.ReadLine();
                Console.WriteLine(eingabe);
            }
        }
    }
}
