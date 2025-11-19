using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// - Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors, excepte ell mateix, és igual a n.Per exemple, 6 és perfecte, 
        /// ja que 6=1+2+3 
        /// a.Donat un valor enter positiu introduït pel teclat, indicar si és perfecte o no. 
        /// b.Escriu la funció public static bool EsPerfecte(int n) que retorna true si n és un número perfecte i seguidament, reescriu el programa 5a usant la funció. 
        /// c.Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és perfecte o no(CERCA O RECORREGUT?). 
        /// Usar el fitxer PERFECTES.TXT que conté el 33550336 que és perfecte i el 6 que també és perfecte. 
        /// d.Donada la mateixa seqüència del fitxer de l’apartat 5c, informar si hi ha algun nombre perfecte a la seqüència (CERCA O RECORREGUT?). Usar el fitxer PERFECTES.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string solucio;
            Console.WriteLine("Quina versió vols executar? (a, b, c o d): ");
            solucio = Console.ReadLine();
            Console.Clear();

            if (solucio == "a")
            {
                Console.WriteLine("Has escollit la versió a!");
                int num;
                Console.Write("Introdueix un número enter positiu: ");
                num = Convert.ToInt32(Console.ReadLine());

                int sumaDivisors;
                int i;

                sumaDivisors = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sumaDivisors += i;
                }

                if (sumaDivisors == num)
                    Console.WriteLine($"{num} és un número perfecte!");
                else
                    Console.WriteLine($"{num} no és un número perfecte.");
            }

            else if (solucio == "b")
            {
                Console.WriteLine("Has escollit la versió b!");
                int num;
                Console.Write("Introdueix un número enter positiu: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (EsPerfecte(num))
                    Console.WriteLine($"{num} és un número perfecte!");
                else
                    Console.WriteLine($"{num} no és un número perfecte.");
            }

            else if (solucio == "c")
            {
                Console.WriteLine("Has escollit la versió c!");
                const string FILENAME = "PERFECTES.TXT";
                string linia;
                int valor;  
                StreamReader sr = new StreamReader(FILENAME);
                linia = sr.ReadLine();

                while (linia != null)
                {
                    valor = Convert.ToInt32(linia);

                    if (EsPerfecte(valor))
                        Console.WriteLine($"{valor} és perfecte!");
                    else
                        Console.WriteLine($"{valor} no és perfecte.");

                    linia = sr.ReadLine();
                }

                sr.Close();
            }

            else if (solucio == "d")
            {
                Console.WriteLine("Has escollit la versió d!");
                const string FILENAME = "PERFECTES.TXT";
                string linia;
                int valor;
                bool trobat;
                trobat = false;
                valor = 0;
                linia = ""; 
                StreamReader sr = new StreamReader(FILENAME);
                linia = sr.ReadLine();
                while (linia != null && !trobat)
                {
                    valor = Convert.ToInt32(linia);
                    if (EsPerfecte(valor))
                        trobat = true;
                    else
                        linia = sr.ReadLine();
                }
                sr.Close();

                if (trobat)
                    Console.WriteLine($"He trobat almenys un número perfecte: {valor}");
                else
                    Console.WriteLine("No hi ha cap número perfecte al fitxer.");       
            }
            else
                Console.WriteLine("Ep! Has d’escollir entre 'a', 'b', 'c' o 'd'.");
        }

        /// <summary>
        /// Aquesta funció ens serveix per saber si un nombre és perfecte o no.
        /// </summary>
        /// <param name="n">Número enter positiu a comprovar</param>
        /// <returns>Retorna true si n és perfecte, false en cas contrari.</returns>
        public static bool EsPerfecte(int n)
        {
            int sumaDivisors;
            int i;
            sumaDivisors = 0;

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sumaDivisors += i;
            }

            return sumaDivisors == n;
        }
    }
}