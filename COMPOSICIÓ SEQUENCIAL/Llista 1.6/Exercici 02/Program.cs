namespace Exercici_02
{
    internal class Program
    {
        /// <summary>
        /// Escriure els 20 primers números parells.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int parells;
            Console.WriteLine("Els 20 primers números en ordre ascendent:");
            for (parells = 2; parells <= 40; parells = parells + 2)
            {
                Console.WriteLine(parells);
            }
        }
    }
}
