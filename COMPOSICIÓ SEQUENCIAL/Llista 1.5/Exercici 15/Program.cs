using System.Net;

namespace Exercici_15
{
    internal class Program
    {
        /// <summary>
        ///  Hem obtingut els resultats del Girona de la temporada 23/24 en un fitxer CSV. El fitxer Girona lliga23_24.txt. Cada dos files 
        ///  representen una jornada: la primera fila és el resultat del rival (posicions senars) i la segona és del Girona (posicions parells). 
        ///  Cal comptar els partits guanyats, perduts i empatats del Girona. Cada victòria suma 3 punts i cada empat 1 punt. Calcula el total de 
        ///  punts obtinguts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "Girona lliga23_24.txt";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            string liniaRival;
            string liniaGirona;
            int golsRival, golsGirona, guanyats, empatats, perduts, punts;
            guanyats = 0;
            empatats = 0;
            perduts = 0;
            punts = 0;
            liniaRival = sR.ReadLine();
            liniaGirona = sR.ReadLine();
            while (liniaRival != MF && liniaGirona != MF)
            {
                golsRival = Convert.ToInt32(liniaRival);
                golsGirona = Convert.ToInt32(liniaGirona);
                if (golsGirona > golsRival)
                {
                    guanyats = guanyats + 1;
                    punts = punts + 3;
                }
                else if (golsGirona == golsRival)
                {
                    empatats = empatats + 1;
                    punts = punts + 1;
                }
                else
                {
                    perduts = perduts + 1;
                }
                liniaRival = sR.ReadLine();
                liniaGirona = sR.ReadLine();
            }
            sR.Close();
            Console.WriteLine($"Partits guanyats: {guanyats}, partits empatats: {empatats}, partits perduts: {perduts} i punts totals: {punts}");
        }
    }
}
