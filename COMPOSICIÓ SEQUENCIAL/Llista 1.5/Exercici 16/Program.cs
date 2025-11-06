using System;
using System.Runtime.ConstrainedExecution;

namespace Exercici_16
{
    internal class Program
    {
        /// <summary>
        /// S'introdueix per teclat el valor del radi r d'una circumferència. Tenim un fitxer anomenat coordenades.txt. Cada línia senar conté 
        /// una coordenada x.Cada línia parell conté una coordenada y. -2,6 → coordenada x 3,8 → coordenada y. El fitxer acaba amb un valor nul 
        /// per a x per indicar el final. El programa ha d'informar si cada punt està dins, fora o sobre el perímetre de la circumferència. 
        /// La circumferència té centre a (0, 0) i radi r.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "coordenades.txt";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            Console.Write("Introdueix el radi de la circumferència: ");
            double r, x, y, distancia; 
            r = Convert.ToDouble(Console.ReadLine());
            string liniaX, liniaY;
            liniaX = sR.ReadLine();
            while (liniaX != MF)
            {
                x = Convert.ToDouble(liniaX);
                liniaY = sR.ReadLine();
            
                {
                    y = Convert.ToDouble(liniaY);
                    distancia = Math.Sqrt(x * x + y * y);
                    if (distancia < r)
                        Console.WriteLine($"El punt ({x}, {y}) està DINS de la circumferència.");
                    else if (distancia == r)
                        Console.WriteLine($"El punt ({x}, {y}) està SOBRE la circumferència.");
                    else
                        Console.WriteLine($"El punt ({x}, {y}) està FORA de la circumferència.");
                    liniaX = sR.ReadLine();
                }
            }
            sR.Close();
        }
    }
}
