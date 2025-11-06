using System;
using System.Numerics;

namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per convertir una quantitat de polzades a metres. Cal tenir en compte que una polzada són 2,54 cm.
        /// Per assolir el vostre objectiu, cal dissenyar una funció que rebi un paràmetre corresponent a una quantitat de 
        /// polzades.La funció ha de retornar els metres equivalents a les polzades donades arrodonit amb dues xifres decimals.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double polzades, metres;
            Console.WriteLine("Defineix el nombre de polzades que vols convertir a metres: ");
            polzades = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            metres = ConvertidorPolzadesAMetres(polzades);
            Console.WriteLine($"El resultat de convertir {polzades} polzades a metres és: {metres:f4}m!");
        }
        
        /// <summary>
        /// Funció per calcular la conversió de polzades a metres.
        /// </summary>
        /// <param name="polzades">Aquesta variable conté el valor de polzades que es vol convertir a metres entrades per teclat</param>
        /// <returns>Et retorna els metres convertits</returns>
        public static double ConvertidorPolzadesAMetres(double polzades)
        {
            double metresConvertits;
            const double POLZADES_METRE = 0.0254;
            metresConvertits = polzades * POLZADES_METRE;
            return metresConvertits;

        }
    }
}
