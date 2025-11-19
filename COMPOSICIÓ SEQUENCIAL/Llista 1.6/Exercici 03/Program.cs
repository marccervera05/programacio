namespace Exercici_03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani dos números i mostri per pantalla tots els valors compresos entre aquests dos números. 
        /// ENTRA n1: 5 ENTRA n2: 900 5, 6, ………., 900
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Entra el primer nombre: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Entra el segon nombre: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Números compresos entre {n1} i {n2}:");
            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (n1 > n2)
            {
                for (int i = n1; i >= n2; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine("Els dos números són iguals!");
            }
        }
    }
    
}
