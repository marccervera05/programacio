using System.Diagnostics;

namespace Exercici_13
{
    internal class Program
    {
        /// <summary>
        ///  Demana a l'usuari que introdueixi un número enter que representi un any i mostra els 4 dígits per separat.

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, primerDigit, segonDigit, tercerDigit, quartDigit, auxResidu;
            Console.WriteLine("Escriu un nombre de 4 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            primerDigit = numero / 1000;
            auxResidu = numero % 1000;
            segonDigit = auxResidu / 100;
            auxResidu = auxResidu % 100;
            tercerDigit = auxResidu / 10;
            quartDigit = auxResidu % 10;
            Console.WriteLine($"El nombre {numero} separat per dígits: {primerDigit}, {segonDigit}, {tercerDigit} i {quartDigit}");


        }
    }
}
