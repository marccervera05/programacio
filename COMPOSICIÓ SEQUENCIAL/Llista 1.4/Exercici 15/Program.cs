namespace Exercici_15
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per tal de sumar un segon a una hora,minut i segon entrat per teclat.El programa demanarà 
        /// separadament les hores, minuts i segons i mostrarà tant l’hora entrada inicialment, com l’hora incrementada en un 
        /// segon.Cal mostrar en format hh:mm:ss.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hores, minuts, segons;
            string novaHora;
            Console.Write("Introdueix les hores (0-23): ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Introdueix els minuts (0-59): ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Introdueix els segons (0-59): ");
            segons = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            novaHora = SumarUnSegon(hores, minuts, segons);
            Console.WriteLine($"Hora incrementada: {novaHora}");
        }

        /// <summary>
        /// Aquesta funció serveix per sumar un segon a una hora escrita en format hh:mm:ss
        /// </summary>
        /// <param name="h">La variable conté les hores entrades per teclat</param>
        /// <param name="m">La variable conté els minuts entrats per teclat</param>
        /// <param name="s">La variable conté els segons entrats per teclat</param>
        /// <returns>La funció retorna l'hora hh:mm:ss entrada amb el segon sumat</returns>
        public static string SumarUnSegon(int h, int m, int s)
        {
            s = s + 1;
            if (s == 60)
            {
                s = 0;
                m = m + 1;
                if (m == 60)
                {
                    m = 0;
                    h = h + 1;
                    if (h == 24)
                        h = 0;
                }
            }
            return $"{h:00}:{m:00}:{s:00}";
        }

    }

}
