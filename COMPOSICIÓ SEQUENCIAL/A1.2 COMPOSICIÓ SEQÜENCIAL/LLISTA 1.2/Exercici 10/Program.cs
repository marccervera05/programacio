namespace Exercici_10
{
    internal class Program
    {
        /// <summary>
        /// L'altitud dels avions es mesura en peus. 1 metre són 39,27 polzades i 1 peu són 12 polzades. 1 polzada són 2,54 cm.
        /// Escriu un programa que ens demani una quantitat de peus i ens informi del seu equivalent en metres.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double METRE_POLZADES = 39.27;
            const double PEU_POLZADES = 12;
            const double POLZADA_CENTIMETRE = 2.54;
            const double CENTIMETRE_METRE = 0.01;
            double peus, metres;
            Console.WriteLine("Defineix el nombre de peus que vols passar a metres: ");
            peus = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            metres = peus * PEU_POLZADES * POLZADA_CENTIMETRE * CENTIMETRE_METRE;
            Console.WriteLine($"El resultat de convertir {peus} peus a metres és: {metres:f4}m");
        }
    }
}
