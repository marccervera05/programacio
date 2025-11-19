using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Un nombre és primer si és divisible només per ell mateix i per 1. El 0 i l’ 1 es consideren no primers per definició.Escriu un programa per saber si un 
        /// nombre positiu introduït pel teclat és primer o no.
        /// a.Donat un valor enter positiu introduït pel teclat, indicar si és primer o no. 
        /// b.Escriu la funció public static bool EsPrimer(int n) que retorna true si n és un número primer i seguidament, reescriu el programa 6a usant la funció. 
        /// c.Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és primer o no(CERCA O RECORREGUT?) Usar el fitxer ALGUNSPRIMERS.TXT 
        /// d.Dona la mateixa seqüència del fitxer de l’apartat 6c, informar si hi ha algun nombre primer a la seqüència (CERCA O RECORREGUT?) Usar el fitxer ALGUNSPRIMERS.TXT 
        /// e.Escriu un programa que demani un valor n per teclat, i mostri per pantalla els n primers nombres primers.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            Console.Write("Introdueix un nombre positiu: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("El nombre ha de ser positiu!");
            else
            {
                if (EsPrimer(num))
                    Console.WriteLine($"{num} és un nombre primer!");
                else
                    Console.WriteLine($"{num} no és un nombre primer.");
            }
            Console.WriteLine();
            Console.WriteLine("APARTAT c: Llegir del fitxer ALGUNSPRIMERS.TXT i indicar si cada valor és primer o no.");
            const string FILENAME = "ALGUNSPRIMERS.TXT";
            string linia;
            int valor;
            StreamReader srNumeros = new StreamReader(FILENAME);
            linia = srNumeros.ReadLine();
            while (linia != null)
            {
                valor = Convert.ToInt32(linia);
                if (EsPrimer(valor))
                    Console.WriteLine($"{valor} és primer.");
                else
                    Console.WriteLine($"{valor} no és primer.");
                linia = srNumeros.ReadLine();
            }
            srNumeros.Close();
            Console.WriteLine("APARTAT d: Comprovar si hi ha algun nombre primer al fitxer ALGUNSPRIMERS.TXT.");
            StreamReader srFitxer = new StreamReader(FILENAME);
            linia = srFitxer.ReadLine();
            bool trobat;
            trobat = false;
            while (linia != null && !trobat)
            {
                valor = Convert.ToInt32(linia);
                if (EsPrimer(valor))
                    trobat = true;
                else
                    linia = srFitxer.ReadLine();
            }
            srFitxer.Close();

            if (trobat)
                Console.WriteLine("He trobat almenys un nombre primer al fitxer!");
            else
                Console.WriteLine("No hi ha cap nombre primer al fitxer.");

            Console.WriteLine("APARTAT e: Mostrar els n primers nombres primers.");
            int n;
            Console.Write("Introdueix quants nombres primers vols mostrar: ");
            n = Convert.ToInt32(Console.ReadLine());
            int comptador;
            comptador = 0;
            num = 2;
            while (comptador < n)
            {
                if (EsPrimer(num))
                {
                    Console.WriteLine(num);
                    comptador++;
                }
                num++;
            }
        }

        /// <summary>
        /// Aquesta funció ens serveix per saber si un nombre és o no primer.
        /// </summary>
        /// <param name="n">La variable n conté el valor de l'enter que volem avaluar</param>
        /// <returns>La funció retorna de manera booleana si el número és o no primer</returns>
        public static bool EsPrimer(int n)
        {
            bool esPrimer;
            esPrimer = true;
            if (n <= 1)
                esPrimer = false;
            else
            {
                int i;
                i = 2;
                while (i <= n / 2 && esPrimer)
                {
                    if (n % i == 0)
                        esPrimer = false;
                    else
                        i++;
                }
            }
            return esPrimer;
        }
    }
}
