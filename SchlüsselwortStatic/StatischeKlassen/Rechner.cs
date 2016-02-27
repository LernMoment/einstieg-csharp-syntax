using System;

namespace SchlüsselwortStatic.StatischeKlassen
{
    public class Rechner
    {
        public int Resultat { get; private set; }

        public Rechner()
        {
            Resultat = 0;
        }

        public int Addiere(int summand)
        {
            Resultat = Resultat + summand;

            return Resultat;
        }
    }
}
