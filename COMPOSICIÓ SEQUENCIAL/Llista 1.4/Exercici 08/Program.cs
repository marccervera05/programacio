using System.Diagnostics.Metrics;

namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Valideu d’una hora en format 24 hores: Feu un programa que pregunti una hora en format de 24 hores i que ens digui si 
        /// aquesta és correcta o no.Cal introduïr un sol enter en format hhmmss. Per exemple, el número 153045 és correcte, però 
        /// el número 250000 no és correcte. public static bool HoraValida(int h, int m, int s).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix una hora en format hhmmss (per exemple, 235959): ");
            int horaEntrada = Convert.ToInt32(Console.ReadLine());

            if (HoraValida(horaEntrada))
                Console.WriteLine("L'hora és correcta.");
            else
                Console.WriteLine("Ep, l'hora no és correcta.");
        }

        /// <summary>
        /// Aquesta funció serveix per esmentar si el format donat per teclat (hhmmss) és o no correcte.
        /// </summary>
        /// <param name="horaTotal">La vari</param>
        /// <returns>La funció retorna si la hora entrada és o no correcte</returns>
        public static bool HoraValida(int horaEntrada)
        {
            int hores = horaEntrada / 10000;
            int minuts = (horaEntrada / 100) % 100;
            int segons = horaEntrada % 100;
            bool horaCorrecta = (hores >= 0 && hores < 24) && ///És una forma de dir i (AND), si no es compleix tot, no és cert.
                                (minuts >= 0 && minuts < 60) &&
                                (segons >= 0 && segons < 60);
            return horaCorrecta;
        }
    }
}
