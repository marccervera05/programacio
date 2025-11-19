namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat i que els sumi. Al final del recorregut ha de mostrar la suma de tots els números.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, nombreEntrat, total;
            i = 0;
            total = 0;
            for (i = 0; i < 10; i++) 
            {
                Console.WriteLine("Entra un nombre: ");
                nombreEntrat = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                total += nombreEntrat;
            }
            Console.WriteLine($"La suma de tots els nobres que has entrat equival a {total}");
        }
    }
}
