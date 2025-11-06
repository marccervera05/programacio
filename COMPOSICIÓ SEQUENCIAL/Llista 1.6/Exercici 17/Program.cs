using System.Runtime.ConstrainedExecution;

namespace Exercici_17
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostri per pantalla totes les taules de multiplicar del 0 al 10. Utilitzar el procediment MostrarTaula, que mostri per pantalla 
        /// la taula de multiplicar d’un número passat per paràmetre. fes servir una funcio public static void MostrarTaula(int numTaula) a part del programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num <= 10; num++)
            {
                MostrarTaula(num);
            }
        }
        /// <summary>
        /// Aquesta funció serveix per mostrar la taula de multiplicar
        /// </summary>
        /// <param name="numTaula"></param>
        public static void MostrarTaula(int numTaula)
        {
            Console.WriteLine("Taula del " + numTaula + ":");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numTaula + " x " + i + " = " + (numTaula * i));
            }
            Console.WriteLine();
        }
    }

}
