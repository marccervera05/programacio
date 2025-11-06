using System;
using System.Drawing;

namespace Exercici_12
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer coordenades2.txt on en la primera línia trobarem la quantitat de coordenades que té el fitxer i la resta contenen les coordenades 
        /// de diferents punts amb el següent format: cada coordenada x a cada línia senar i cada coordenada y a cada línia parell.S'introdueix per teclat el valor 
        /// del radi r d'una circumferència. Un exemple de fitxer amb el format especificat anteriorment: -2,6 → coordenada x, 3,8 → coordenada y. . . 
        /// El programa ha d'informar per a cada punt si està dins, fora o sobre el perímetre de la circumferència de radi r i centre (0.0). Crea i utilitza la 
        /// funció Distancia que retorna la distància d’un punt a l’eix de coordenades. public static double Distancia(double x, double y)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "coordenades2.txt";
            StreamReader srCoord = new StreamReader(FILENAME);
            int totalPunts, i;
            double r, x, y, distancia;
            totalPunts = Convert.ToInt32(srCoord.ReadLine());
            Console.Write("Introdueix el radi de la circumferència: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Resultats:");
            for (i = 1; i <= totalPunts; i++)
            {
                x = Convert.ToDouble(srCoord.ReadLine());
                y = Convert.ToDouble(srCoord.ReadLine());
                distancia = Distancia(x, y);
                Console.Write($"Punt {i} ({x}, {y}): ");
                if (distancia < r)
                    Console.WriteLine("dins de la circumferència");
                else if (distancia == r)
                    Console.WriteLine("sobre la circumferència");
                else
                    Console.WriteLine("fora de la circumferència");
            }
            srCoord.Close();
        }
        /// <summary>
        /// Aquesta funció serveix per calcular la distància entre dos punts
        /// </summary>
        /// <param name="x">La variable conte el valor del punt x</param>
        /// <param name="y">La variable conte el valor del punt y</param>
        /// <returns>Retorna el valor de la distancia entre els dos punts</returns>
        public static double Distancia(double x, double y)
        {
            double d;
            d = Math.Sqrt(x * x + y * y);
            return d;
        }
    }
}
