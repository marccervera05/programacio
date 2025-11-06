using System.Net;

namespace Exercici_13
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer Girona lliga23_24_v2.txt que conté resultats del Girona de la temporada 23/24 en un fitxer CSV.Realitza el mateix exercici que 
        /// férem als recorreguts sabent que la primera entrada ens dirà el total de jornades de la lliga.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "Girona_lliga23_24_v2.txt";
            StreamReader srGirona = new StreamReader(FILENAME);
            int totalJornades, punts, partitsJugats, guanyats, empatats, perduts, golsFavor, golsContra, i, pos1, pos2, pos3, golsLocal, golsVisitant, golsGirona, golsRival;
            string linia;
            totalJornades = Convert.ToInt32(srGirona.ReadLine());
            partitsJugats = 0;
            guanyats = 0;
            empatats = 0;
            perduts = 0;
            golsFavor = 0;
            golsContra = 0;
            for (i = 1; i <= totalJornades; i++)
            {
                linia = srGirona.ReadLine();
                pos1 = linia.IndexOf(',');
                pos2 = linia.IndexOf(',', pos1 + 1);
                pos3 = linia.IndexOf(',', pos2 + 1);
                string equipLocal = linia.Substring(0, pos1);
                golsLocal = Convert.ToInt32(linia.Substring(pos1 + 1, pos2 - pos1 - 1));
                string equipVisitant = linia.Substring(pos2 + 1, pos3 - pos2 - 1);
                golsVisitant = Convert.ToInt32(linia.Substring(pos3 + 1));
                partitsJugats = partitsJugats + 1;
                golsGirona = 0;
                golsRival = 0;
                if (equipLocal == "Girona")
                {
                    golsGirona = golsLocal;
                    golsRival = golsVisitant;
                }
                else
                {
                    if (equipVisitant == "Girona")
                    {
                        golsGirona = golsVisitant;
                        golsRival = golsLocal;
                    }
                }
                golsFavor = golsFavor + golsGirona;
                golsContra = golsContra + golsRival;
                if (golsGirona > golsRival)
                    guanyats = guanyats + 1;
                else
                    if (golsGirona == golsRival)
                        empatats = empatats + 1;
                    else
                        perduts = perduts + 1;
            }
            srGirona.Close();
            punts = guanyats * 3 + empatats;
            Console.WriteLine($"Total de jornades: {totalJornades}");
            Console.WriteLine($"Partits jugats: {partitsJugats}");
            Console.WriteLine($"Guanyats: {guanyats}");
            Console.WriteLine($"Empatats: {empatats}");
            Console.WriteLine($"Perduts: {perduts}");
            Console.WriteLine($"Gols a favor: {golsFavor}");
            Console.WriteLine($"Gols en contra: {golsContra}");
            Console.WriteLine($"Punts totals: {punts}");
        }
    }
}
