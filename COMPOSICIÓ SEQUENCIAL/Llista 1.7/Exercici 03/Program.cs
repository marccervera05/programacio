

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
                string solucio;
                Console.WriteLine("Defineix quina versió vols executar (entra 'a' o 'b'): ");
                solucio = Console.ReadLine();
                Console.Clear();

                if (solucio == "a")
                {
                    Console.WriteLine("Has escollit la versió a!");

                    const string FILENAME = "NUMEROS.TXT";
                    string linia;
                    int valor;
                    valor = 0;
                    bool trobat;
                    trobat = false;

                    StreamReader srNumeros = new StreamReader(FILENAME);
                    linia = srNumeros.ReadLine();

                    while (linia != null && !trobat)
                    {
                        valor = Convert.ToInt32(linia);
                        if (EsParell(valor))
                            trobat = true;
                        else
                            linia = srNumeros.ReadLine();
                    }
                    srNumeros.Close();
                    if (trobat)
                        Console.WriteLine($"He trobat almenys un nombre parell: {valor}");
                    else
                        Console.WriteLine("No hi ha cap nombre parell al fitxer.");
                    
                }
                else if (solucio == "b")
                {
                    Console.WriteLine("Has escollit la versió b!");
                    Console.WriteLine("Introdueix nombres enters (acaba amb -9999):");
                    bool trobat;
                    int num;
                    trobat = false;
                    num = 0;
                    while (num != -9999 && !trobat)
                    {
                        Console.Write("Número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num != -9999)
                        {
                            if (EsParell(num))
                                trobat = true;
                        }
                    }
                    if (trobat)
                        Console.WriteLine("He trobat almenys un nombre parell!");
                    else
                        Console.WriteLine("No hi ha cap nombre parell a la seqüència.");
                }
                else
                    Console.WriteLine("Ep! Has d'escollir entre 'a' o 'b'.");
        }

    /// <summary>
    /// Aquesta funció ens serveix per saber si un nombre és o no parell. 
    /// </summary>
    /// <param name="n">La variable n conté el valor de l'enter que volem evaluar</param>
    /// <returns>La funció retorna de manera booleana si el número és o no parell</returns>
    public static bool EsParell(int n)
        {
            return n % 2 == 0;
        }
    }
}
