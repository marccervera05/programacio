using System.Xml.Linq;

namespace Exercici_01
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per contar quants valors enters introdueix un usuari per Consola. Deixarem  de contar valors en trobar el valor 0. 
        /// Quin és el primer element que tractarem? Quina és la condició de final de recorregut?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int MF = 0;
            int valor, nElements;
            nElements = 0;
            Console.WriteLine("ENTRA UN ENTER (0 PER ACABAR): ");
            valor = Convert.ToInt32(Console.ReadLine());
            while (valor != MF)
            {
                nElements = nElements + 1;
                Console.WriteLine("ENTRA UN ENTER (0 PER ACABAR): ");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"HAN APAREGUT {nElements}");
        }
    }
}
