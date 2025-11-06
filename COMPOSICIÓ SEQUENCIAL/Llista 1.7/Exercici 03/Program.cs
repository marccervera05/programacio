using System;
using System.Runtime.ConstrainedExecution;

namespace Exercici_03
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell. 
        /// a.Versió 1: La seqüència prové d’un fitxer de text(un enter per línia). 
        /// Usarem el fitxer NUMEROS.TXT que conté molts números parells i NUMEROS2.TXT que no conté cap número parell. 
        /// b. Versió 2: La seqüència prové del teclat i acaba amb -9999.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string MF = null;
            int valor;
            valor = 0;
            bool trobat;
            trobat = false;
            const string FILENAME = "NUMEROS.TXT";
            string linia;
            StreamReader srNumeros = new StreamReader(FILENAME);
            linia = srNumeros.ReadLine();
            while (linia != MF && !trobat)
            {
                valor = Convert.ToInt32(linia);
                if (EsParell(valor))
                    trobat = true;
                else
                    linia = srNumeros.ReadLine();
            }
            if (trobat)
                Console.WriteLine($"He trobat al menys 1 nombre parell: {valor}");
            else
                Console.WriteLine($"No hi ha cap valor parell a la seqüència");

            srNumeros.Close();
        }
        public static bool EsParell(int n)
        {
            return n % 2 == 0;
        }
    }
}
