using System.Drawing;

namespace Exercici_03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per a saber quants valors positius i negatius hem introduït per teclat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int element, nElements, nPositius, nNegatius;
            nElements = 0;
            nPositius = 0;
            nNegatius = 0;
            const int MF = 0;
            Console.WriteLine("ENTRA UN ENTER (0 PER ACABAR): ");
            element = Convert.ToInt32(Console.ReadLine());
            while (element != MF)
            {
                if (element > 0)
                    nPositius = nPositius + 1;
                else
                    nNegatius = nNegatius + 1;
                Console.WriteLine("ENTRA UN ENTER (0 PER ACABAR): ");
                element = Convert.ToInt32(Console.ReadLine());
            }
            nElements = nPositius + nNegatius;
            Console.WriteLine($"Han aparegut un total de {nElements} elements, dels quals {nPositius} són positius i {nNegatius} són negatius.");
        }
    }
}
