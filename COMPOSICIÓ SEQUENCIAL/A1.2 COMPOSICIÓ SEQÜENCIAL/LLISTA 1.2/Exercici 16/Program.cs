using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Exercici_16
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que ens mostri el resultat aleatori del partit Paris Sant Germain - Girona de forma que
        /// tant el valor dels gols d’un com de l’altre equip sigui un valor a l’atzar entre 0 i 6.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random r = new Random();
            int golsGirona = r.Next(7);
            int golsPSG = r.Next(7);
            Console.WriteLine($"PGG {golsPSG} - GIRONA {golsGirona}");
        }
    }
}
