using System.Drawing;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Exercici_02
{
    internal class Program
    {
        /// <summary>
        /// La distància entre dos punts en el pla (x1,y1) i (x2,y2) es calcula mitjançant la següent fòrmula: d = sqrt((x2 - x1)^2
        /// + (y2 - y1)^2). Escriu un programa que et demani per teclat els valors de dos punts i ens mostri el valor de la 
        /// distància entre els dos punts.El càlcul cal fer-lo dissenyant una funció que rebi 4 paràmetres corresponents a les 
        /// coordenades x i y de cada punti ens retorni el valor de la distància entre el dos punts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double abscissaPrimerPunt, ordenadaPrimerPunt, abscissaSegonPunt, ordenadaSegonPunt, distanciaTotal;
            Console.WriteLine("Defineix la coordenada abscissa del primer punt: ");
            abscissaPrimerPunt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix la coordenada ordenada del primer punt: ");
            ordenadaPrimerPunt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix la coordenada abscissa del segon punt: ");
            abscissaSegonPunt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix la coordenada ordenada del segon punt: ");
            ordenadaSegonPunt = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            distanciaTotal = DistanciaEntrePunts(abscissaPrimerPunt, ordenadaPrimerPunt, abscissaSegonPunt, ordenadaSegonPunt);
            Console.WriteLine($"La distància entre els dos punts que has definit ({abscissaPrimerPunt},{ordenadaPrimerPunt}) i " +
                $"({abscissaSegonPunt},{ordenadaSegonPunt}) és: {distanciaTotal:f4}");
        }

        /// <summary>
        /// Funció per calcular la distància entre dos punts cartesians sobre un pla en dos dimensions.
        /// </summary>
        /// <param name="abscissaPrimerPunt">Aquesta variable conté el valor x1 d'un punt</param>
        /// <param name="ordenadaPrimerPunt">Aquesta variable conté el valor y1 d'un punt</param>
        /// <param name="abscissaSegonPunt">Aquesta variable conté el valor x2 d'un punt</param>
        /// <param name="ordenadaSegonPunt">Aquesta variable conté el valor y2 d'un punt</param>
        /// <returns>Et retorna la distància entre dos punts cartesians</returns>
        public static double DistanciaEntrePunts(double abscissaPrimerPunt, double ordenadaPrimerPunt, double abscissaSegonPunt, double ordenadaSegonPunt)
        {
            double distanciaTotal;
            distanciaTotal = Math.Sqrt((Math.Pow(abscissaSegonPunt - abscissaPrimerPunt, 2) + Math.Pow(ordenadaSegonPunt - ordenadaPrimerPunt, 2)));
            return distanciaTotal;
        } 
            
    }
}
