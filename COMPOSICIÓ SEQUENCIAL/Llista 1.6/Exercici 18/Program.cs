namespace Exercici_18
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostre una piràmide de números com la següent (img)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nombrePisos, i, j, k;
            Console.WriteLine("Defineix el nombre de pisos que tindrà la piràmide (ha de ser un enter positiu): ");
            nombrePisos = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (nombrePisos <= 0)
                Console.WriteLine("Ep, la piràmide no pot tenir pisos negatius ni iguals a 0. Torna-ho a intentar!");
            else
            {
                for (i = 1; i <= nombrePisos; i++)
                {
                    for (j = 1; j < nombrePisos - i; j++)
                    {
                        Console.Write(" ");
                    }
                        for (k = 1; k <= i; k++)
                        {
                            Console.Write(k + " ");
                        }
                    Console.WriteLine();
                }
            }
        }

    }
}
