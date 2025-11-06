using System.Runtime.ConstrainedExecution;

namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calculi la suma del número 1 al número entrat per l’usuari. 
        /// ENTRA UN NÚMERO: 4 (10 //1+2+3+4)

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, suma;
            Console.Write("Entra un número: ");
            numero = Convert.ToInt32(Console.ReadLine();
            suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma del 1 al {numero} és: {suma}");
        }
    }
}
