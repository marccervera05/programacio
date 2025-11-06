using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// Feu un programa que et demani un nombre enter per teclat i t'informo: si és parell o senar i si és múltiple de 7 o no. 
        /// public static bool EsParell(int n) i public static bool EsMultipleDe7(int n).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nombre;
            bool parell, multipleDeSet;
            Console.Write("Entra un enter per teclat: ");
            nombre = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            parell = EsParell(nombre);
            multipleDeSet = EsMultipleDe7(nombre);
            if (parell)
                Console.WriteLine($"El nombre {nombre} és parell.");
            else
                Console.WriteLine($"El nombre {nombre} és senar.");

            if (multipleDeSet)
                Console.WriteLine($"El nombre {nombre} és múltiple de 7.");
            else
                Console.WriteLine($"El nombre {nombre} no és múltiple de 7.");
        }

        /// <summary>
        /// Aquestà funció serveix per veure si un nombre enter és parell, ho farem dividint-lo per el residu de 2, si el resultat
        /// del residu es 0, serà parell.
        /// </summary>
        /// <param name="nombre">Aquesta variable conté el valor del nombre entrat per teclat</param>
        /// <returns>La funció retorna si el nombre és parell "true" o si es senar "false"</returns>
        public static bool EsParell(int nombre)
        {
            return nombre % 2 == 0;
        }

        /// <summary>
        /// Aquesta funció serveix per veure si el nombre entrat per teclat és multiple de 7 o no. Per fer-ho, dividirem pel residu
        /// de 7 i en cas que doni 0, serà múltiple.
        /// </summary>
        /// <param name="nombre">Aquesta variable conté el valor del nombre entrat per teclat</param>
        /// <returns>La funció retorna si el nombre és múltiple de 7 amb un true o si no ho és amb un false.</returns>
        public static bool EsMultipleDe7(int nombre)
        {
            return nombre % 7 == 0;
        }

    }
}
