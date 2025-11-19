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

            int totalJornades, partitsJugats, guanyats, empatats, perduts, golsFavor, golsContra, punts;
            totalJornades = Convert.ToInt32(srGirona.ReadLine());
            partitsJugats = 0;
            guanyats = 0;
            empatats = 0;
            perduts = 0;
            golsFavor = 0;
            golsContra = 0;

            for (int i = 1; i <= totalJornades; i++)
            {
                string linia = srGirona.ReadLine();

                string equipLocal = "";
                string golsLocalText = "";
                string equipVisitant = "";
                string golsVisitantText = "";

                int camp = 0;

            /// Canviar a simple 
            for (int j = 0; j < linia.Length; j++)
            {
                char c = linia[j];

                if (c == ',')
                {
                    camp++;
                }
                else
                {
                    if (camp == 0) equipLocal += c;
                    else if (camp == 1) golsLocalText += c;
                    else if (camp == 2) equipVisitant += c;
                    else if (camp == 3) golsVisitantText += c;
                    }
                }
                int golsLocal = Convert.ToInt32(golsLocalText);
                int golsVisitant = Convert.ToInt32(golsVisitantText);

                partitsJugats++;

                int golsGirona = 0;
                int golsRival = 0;

                if (equipLocal == "Girona")
                {
                    golsGirona = golsLocal;
                    golsRival = golsVisitant;
                }
                else if (equipVisitant == "Girona")
                {
                    golsGirona = golsVisitant;
                    golsRival = golsLocal;
                }
                golsFavor += golsGirona;
                golsContra += golsRival;

                if (golsGirona > golsRival) guanyats++;
                else if (golsGirona == golsRival) empatats++;
                else perduts++;
            }
            srGirona.Close();
            
            punts = guanyats * 3 + empatats;
            Console.WriteLine($"Total jornades: " + totalJornades +
                " Partits jugats: " + partitsJugats +
                " Guanyats: " + guanyats +
                " Empatats: " + empatats +
                " Perduts: " + perduts +
                " Gols a favor: " + golsFavor +
                " Gols en contra: " + golsContra +
                " Punts totals: " + punts );
        }
    }
}
