using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per mostrar el volum d’una esfera de radi r i l’àrea i el perímetre del seu cercle inscrit.
        /// Per fer.ho, dissenyeu tres funcions, cadascuna rep el radi i cadascuna retorna el resultat de cada càlcul. S’ha de 
        /// retornar un valor arrodonit amb dues xifres decimals.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double radi, volum, area, perimetre;
            Console.WriteLine("Defineix el valor del radi: ");
            radi = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            volum = VolumEsfera(radi);
            area = AreaEsfera(radi);
            perimetre = PerimetreEsfera(radi);
            Console.WriteLine($"L'esfera de radi {radi} que has definit fa {volum:f2} unitats cúbiques de volum, {area:f2} unitats " +
                $"quadrades d'area i {perimetre:f2} unitats de perímetre.");
        }

        /// <summary>
        /// Funció que serveix per calcular el volum d'una esfera a través d'un radi r.
        /// </summary>
        /// <param name="radi">Aquesta variable conté el valor del radi de l'esfera entrat per teclat</param>
        /// <returns>Retorna el valor del volum d'una esfera de radi r</returns>
        public static double VolumEsfera(double radi)
        {
            const double NUMERO_PI = 3.141592;
            double volum;
            volum =1.333333333 * radi * radi * radi * NUMERO_PI;
            return volum;
        }

        /// <summary>
        /// Funció que serveix per a calcular el valor de l'area d'una esfera a partir d'un radi donat r.
        /// </summary>
        /// <param name="radi">Aquesta variable conté el valor del radi de l'esfera entrat per teclat</param>
        /// <returns>Retorna el valor del volum d'una esfera de radi r</returns>
        public static double AreaEsfera(double radi)
        {
            
            double area;
            area = 4 * Math.PI * radi * radi;
            return area;
        }

        /// <summary>
        /// Funció que serveix per calcular el perímetre d'una esfera a base d'un radi r entrat.
        /// </summary>
        /// <param name="radi">Aquesta variable conté el valor del radi de l'esfera entrat per teclat</param>
        /// <returns>Retorna el valor del perimetre d'una esfera de radi r</returns>
        public static double PerimetreEsfera(double radi)
        {
            const double NUMERO_PI = 3.141592;
            double perimetre;
            perimetre = 2 * NUMERO_PI * radi;
            return perimetre;
            
        }
    }
}
