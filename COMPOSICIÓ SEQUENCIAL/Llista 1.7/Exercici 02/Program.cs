namespace Exercici_02
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un número per línia. 
        /// a.Versió 1: La seqüència prové d’un fitxer de text que conté com a mínim un número. Usarem el fitxer NUMEROS.TXT 
        /// b.Versió 2: La seqüència prové del teclat i acaba amb -9999.
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
                int primerValor;
                int valorActual;
                bool repetit;
                repetit = false;
                primerValor = 0;   
                StreamReader sr = new StreamReader(FILENAME);
                linia = sr.ReadLine();
                primerValor = Convert.ToInt32(linia);
                linia = sr.ReadLine();
                while (linia != null && !repetit)
                {
                    valorActual = Convert.ToInt32(linia);

                    if (valorActual == primerValor)
                        repetit = true;
                    else
                        linia = sr.ReadLine();
                }
                sr.Close();
                if (repetit)
                    Console.WriteLine($"El primer valor ({primerValor}) es repeteix a la seqüència!");
                else
                    Console.WriteLine($"El primer valor ({primerValor}) no es repeteix.");
                
            }
            else if (solucio == "b")
            {
                Console.WriteLine("Has escollit la versió b!");
                Console.WriteLine("Introdueix nombres enters (acaba amb -9999):");
                int primerValor;
                int num;
                bool primerLlegit;
                bool repetit;
                primerLlegit = false;
                repetit = false;
                num = 0;
                primerValor = 0;
                while (num != -9999 && !repetit)
                {
                    Console.Write("Número: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (!primerLlegit && num != -9999)
                    {
                        primerValor = num;
                        primerLlegit = true;
                    }
                    else if (num != -9999)
                    {
                        if (num == primerValor)
                            repetit = true;
                    }
                }

                if (primerLlegit)
                {
                    if (repetit)
                        Console.WriteLine($"El primer valor ({primerValor}) es repeteix a la seqüència!");
                    else
                        Console.WriteLine($"El primer valor ({primerValor}) no es repeteix.");
                }
                else
                    Console.WriteLine("No s’ha introduït cap número vàlid!");
            }
            else
                Console.WriteLine("Ep! Has d’escollir entre 'a' o 'b'.");
        }
    }
}
