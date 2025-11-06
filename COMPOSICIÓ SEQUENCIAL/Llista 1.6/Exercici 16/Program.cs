using static System.Net.Mime.MediaTypeNames;

namespace Exercici_16
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri una piràmide. ENTRA UN NÚMERO: 4, (intro)*, (intro)**, (intro)***, (intro)**** 
        /// Utilitzar la funció GenerarLinia, que genera una cadena de text d'una longitud específica amb un caràcter donat. public static string GenerarLinia(char car, int longitud)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, i;
            string linia;
            Console.Write("Entra un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                linia = GenerarLinia('*', i);
                Console.WriteLine(linia);
            }
        }

        /// <summary>
        /// Genera una cadena de text formada pel caràcter indicat repetit una quantitat donada.
        /// Exemple: GenerarLinia('*', 3) → "***"
        /// </summary>
        /// <param name="car">Caràcter a repetir</param>
        /// <param name="longitud">Nombre de vegades que es repetirà</param>
        /// <returns>Cadena amb el caràcter repetit</returns>
        public static string GenerarLinia(char car, int longitud)
        {
            int i;
            string resultat;
            resultat = "";
            for (i = 0; i < longitud; i++)
            {
                resultat += car;
            }
            return resultat;
        }
    }
}