namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per mostrar el resultat del residu i la divisió entera de 2 números enters.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int divident, divisor, residu;
            Console.WriteLine("Defineix el divident de la fracció: ");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ara defineix el divisor de la fracció: ");
            divisor = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            residu = divident % divisor;
            Console.WriteLine($"El residu de la divisió del nombre {divident} entre {divisor} té com a resultat: {residu}");
        }
    }
}
