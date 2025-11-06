using System.Drawing;
using System.Xml.Linq;

namespace Exercici_04
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS.TXT";
            int nElements, nPositius, nNegatius, element;
            nElements = 0;
            nPositius = 0;
            nNegatius = 0;
            using StreamReader sR = new StreamReader(FILENAME);
            string linia;
            linia = sR.ReadLine();
            while (linia != null)
            {
                element = Convert.ToInt32(linia);
                nElements++;
                if (element > 0)
                    nPositius++;
                else
                    nNegatius++;
                linia = sR.ReadLine();
            }
            Console.WriteLine($"Han aparegut un total de {nElements} elements, dels quals {nPositius} són positius i {nNegatius} són negatius.");
        }
    }
}
