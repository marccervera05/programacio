namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per convertir una quantitat de polzades a metres. Cal tenir en compte que una polzada són 2,54 cm.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double POLZADES_METRE = 0.0254;
            double polzades, metres;
            Console.WriteLine("Defineix el nombre de polzades que vols convertir a metres: ");
            polzades = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            metres = polzades * POLZADES_METRE;
            Console.WriteLine($"El resultat de convertir {polzades} polzades a metres és: {metres:f4}m!");
        }
    }
}
