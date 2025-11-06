using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_10
{
    /// <summary>
    /// Feu un programa que ens demani per teclat un any i ens digui a quin segle pertany. Tan sols considerarem com a anys vàlids 
    /// els anys que pertanyin al segle XVIII, XIX, XX i XXI.Sinó es considerarà un any invàlid. Has de tenir en compte els 
    /// següents rangs de anys: Segle Anys XVIII[1701 - 1800], XIX [1801 - 1900], XX [1901 - 2000], XXI [2001 - 2100]
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyEntrat;
            string resultat;
            Console.WriteLine("Defineix l'any del que vols saber el segle al qual pertany: ");
            anyEntrat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            resultat = Segle(anyEntrat);
            Console.WriteLine($"Has entrat l'any {anyEntrat}, el qual pertany a el segle {resultat}");
        }

        /// <summary>
        /// Aquesta funció serveix per determinar si l'any entrat esta dins l'interval d'operació del programa i si ho està, 
        /// saber el segle al que pertany l'any entrat.
        /// </summary>
        /// <param name="anyEntrat">Aquesta variable conté el valor de l'any entrat per teclat</param>
        /// <returns>La funció retorna si l'any entrat està dins l'interval o no, en cas de ser  així, ens diu el segle al que pertany</returns>
        public static string Segle(int anyEntrat)
        {
            string segle;
            if (anyEntrat < 1701 || anyEntrat > 2100)
                Console.WriteLine("ERROR");
            
            if (anyEntrat > 1701 && anyEntrat < 1800)
                segle = "XVIII";
            else if (anyEntrat >= 1801 && anyEntrat < 1900)
                segle = "XIX";
            else if (anyEntrat >= 1901 && anyEntrat < 2000)
                segle = "XX";
            else
                segle = "XXI";
               
            return segle;
        }
    }
}
