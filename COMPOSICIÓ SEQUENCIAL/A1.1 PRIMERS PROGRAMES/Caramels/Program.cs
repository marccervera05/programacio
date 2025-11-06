namespace Caramels
{
    internal class Program
    {
        /// <summary>
        /// Un professor ha decidit repartir un total de carmels entre els nens de la seva classe
        /// El professor vol repartir el màxim de carmels per nen, però vol que tots els nens tinguin el mateix nombre de carmels
        /// El professor es quedarà els carmels que sobrin.
        /// El programa ha de demanar el nombre de carmels i el nombre de nens i informar de:
        /// a)Quants carmels toquen per a cada nen
        /// b)Quants carmels es quedarà el professor
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nCarmels, nNens;
            int carmelsPerNen, sobren;
            Console.Clear();
            Console.Write("Quants nens hi ha?");
            nNens = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quants carmels hi ha?");
            nCarmels = Convert.ToInt32(Console.ReadLine());
            carmelsPerNen = nCarmels / nNens;
            sobren = nCarmels % nNens;
            Console.WriteLine($"Total nens:{nNens}\t\t Total carmels:{nCarmels}");
            Console.WriteLine($"Toquen a {carmelsPerNen} carmels per cada nen");
            Console.WriteLine($"El professor es quedarà amb {sobren} carmels");
        }
    }
}
