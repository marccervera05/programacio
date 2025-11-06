namespace Exercici_04
{
    internal class Program
    {
        /// <summary>
        /// Modifica l’anterior programa fent que no es mostrin els números que siguin múltiples de 7.

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, n1, n2;
            Console.Write("Entra el primer nombre: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Entra el segon nombre: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Números compresos entre {n1} i {n2} (sense múltiples de 7):");

            if (n1 < n2)
            {
                for (i = n1; i <= n2; i++)
                {
                    if (i % 7 != 0)  
                        Console.Write($"{i} ");
                }
            }
            else if (n1 > n2)
            {
                for (i = n1; i >= n2; i--)
                {
                    if (i % 7 != 0)   
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
