using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que llegeixi una seqüència d’enters d’un fitxer i ens informi si es compleix sempre la condició que l’element llegit és igual a la 
        /// suma de tots els anteriors que han aparegut. El resultat del programa és "SÍ" si compleix la condició i "NO" si no la compleix. 
        /// (fitxers COMPLEIX.TXT i NOCOMPLEIX.TXT)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string solucio;
            Console.WriteLine("Defineix quin fitxer vols llegir (entra 'a' o 'b'): ");
            Console.WriteLine("a -> COMPLEIX.TXT");
            Console.WriteLine("b -> NOCOMPLEIX.TXT");
            solucio = Console.ReadLine();
            Console.Clear();

            if (solucio == "a")
            {
                Console.WriteLine("Has escollit la versió a! (Fitxer COMPLEIX.TXT)");
                const string FILENAME = "COMPLEIX.TXT";
                ComprovaCondicio(FILENAME);
            }
            else if (solucio == "b")
            {
                Console.WriteLine("Has escollit la versió b! (Fitxer NOCOMPLEIX.TXT)");
                const string FILENAME = "NOCOMPLEIX.TXT";
                ComprovaCondicio(FILENAME);
            }
            else
                Console.WriteLine("Ep! Has d'escollir entre 'a' o 'b'.");
        }

        /// <summary>
        /// Aquesta funció comprova si en un fitxer la seqüència d'enters compleix
        /// que cada element és igual a la suma de tots els anteriors.
        /// </summary>
        /// <param name="fitxer">Nom del fitxer a llegir</param>
        public static void ComprovaCondicio(string fitxer)
        {
            StreamReader srNumeros = new StreamReader(fitxer);
            string linia;
            linia = srNumeros.ReadLine();

            int suma;
            suma = 0;
            int valor;
            valor = 0;
            bool compleix;
            compleix = true;
            int comptador;
            comptador = 0;

            while (linia != null && compleix)
            {
                valor = Convert.ToInt32(linia);
                comptador++;

                if (comptador > 1)
                {
                    if (valor != suma)
                        compleix = false;
                }

                suma = suma + valor;
                linia = srNumeros.ReadLine();
            }

            srNumeros.Close();

            if (compleix)
                Console.WriteLine("SÍ, es compleix la condició per a tots els valors del fitxer.");
            else
                Console.WriteLine("NO, no es compleix la condició.");
        }
    }   
}
