using System;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per mostrar l'hora en format hh:mm:ss a partir d'una quantitat de segons donada com a entrada.
        /// Per exemple, si l'entrada és 4000, la sortida ha de ser 01:04:40. Per fer.ho, dissenyeu una funció que rebi un enter 
        /// corresponent a la quantitat de segons i retorni l’string en el format demanat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int segonsEntrada;
            string horaDigital;
            Console.WriteLine("Quants segons vols passar a format hores:minuts:segons? ");
            segonsEntrada = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            horaDigital = HoraFormatDigital(segonsEntrada);
            Console.WriteLine($"El resultat de convertir {segonsEntrada} segons a format hora és: {horaDigital}");
        }
        
        /// <summary>
        /// Funció que serveix per a calcular les hores, minuts i segons a base d'un total de segons i passar-ho a format horari
        /// </summary>
        /// <param name="segonsEntrada">Aquesta variable conté el valor dels segons inicials entrats per teclat</param>
        /// <returns>Retorna l'hora en format digital</returns>
        public static string HoraFormatDigital(int segonsEntrada)
        {
            const int SEGONS_HORA = 3600;
            const int SEGONS_MINUT = 60;
            int hores, minuts, segons, auxResidu;
            hores = segonsEntrada / SEGONS_HORA;
            auxResidu = segonsEntrada % SEGONS_HORA;
            minuts = auxResidu / SEGONS_MINUT;
            segons = auxResidu % SEGONS_MINUT;
            return $"{hores:D2}:{minuts:D2}:{segons:D2}"; ///Escrivint-ho així, farem que sempre ocupi dos dígits, i en cas que
                                                          ///el nombre donat nomès tingui un digit, hi hauria un 0 al davant.
        }
    }
}
