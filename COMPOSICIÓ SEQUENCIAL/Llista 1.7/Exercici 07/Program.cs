namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// En una cursa de MTB (Mountain Bike), l’organització es pregunta si el ciclista amb el dorsal 231 s’ha perdut.Donada una seqüència de dorsals d’un fitxer 
        /// que indica els ciclistes que arriben a la meta, en ordre d’arribada, informa: 
        /// a.Si el número 231 ha arribat i, en cas afirmatiu, en quina posició ho ha fet. 
        /// b.Si no ha arribat, informar que s’ha perdut.
        /// (useu el fitxer PERDUT.TXT i TROBAT.TXT)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string solucio;
            Console.WriteLine("Defineix quina versió vols executar (entra 'a' o 'b'): ");
            solucio = Console.ReadLine();
            Console.Clear();

            if (solucio == "a")
            {
                Console.WriteLine("Has escollit la versió a! (Fitxer TROBAT.TXT)");
                const string FILENAME = "TROBAT.TXT";
                StreamReader srCiclistes = new StreamReader(FILENAME);

                string linia;
                linia = srCiclistes.ReadLine();

                int dorsal;
                dorsal = 0;
                int posicio;
                posicio = 0;
                bool trobat;
                trobat = false;

                while (linia != null && !trobat)
                {
                    posicio++;
                    dorsal = Convert.ToInt32(linia);
                    if (dorsal == 231)
                        trobat = true;
                    else
                        linia = srCiclistes.ReadLine();
                }

                srCiclistes.Close();

                if (trobat)
                    Console.WriteLine($"El ciclista amb dorsal 231 ha arribat en la posició {posicio}.");
                else
                    Console.WriteLine("El ciclista amb dorsal 231 no ha arribat a meta (s'ha perdut).");
            }
            else if (solucio == "b")
            {
                Console.WriteLine("Has escollit la versió b! (Fitxer PERDUT.TXT)");
                const string FILENAME = "PERDUT.TXT";
                StreamReader srCiclistes = new StreamReader(FILENAME);

                string linia;
                linia = srCiclistes.ReadLine();

                int dorsal;
                dorsal = 0;
                int posicio;
                posicio = 0;
                bool trobat;
                trobat = false;

                while (linia != null && !trobat)
                {
                    posicio++;
                    dorsal = Convert.ToInt32(linia);
                    if (dorsal == 231)
                        trobat = true;
                    else
                        linia = srCiclistes.ReadLine();
                }

                srCiclistes.Close();

                if (trobat)
                    Console.WriteLine($"El ciclista amb dorsal 231 ha arribat en la posició {posicio}.");
                else
                    Console.WriteLine("El ciclista amb dorsal 231 no ha arribat a meta (s'ha perdut).");
            }
            else
                Console.WriteLine("Ep! Has d'escollir entre 'a' o 'b'.");
        }
    }
    }
}
