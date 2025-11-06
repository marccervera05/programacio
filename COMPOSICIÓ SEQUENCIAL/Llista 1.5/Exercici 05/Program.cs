namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana dels valors introduïts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, suma, comptador;
            double mitjana;
            suma = 0;
            comptador = 0;
            Console.WriteLine("Introdueix números (0 per acabar):");   
            numero = Convert.ToInt32(Console.ReadLine());       
            while (numero != 0)
            {
                suma += numero;      
                comptador++;  
                numero = Convert.ToInt32(Console.ReadLine());
            }
            if (comptador > 0)
            {
                mitjana = (double)suma / comptador;
                Console.WriteLine($"La mitjana dels {comptador} valors és: {mitjana:F2}");
            }
            else
            {
                Console.WriteLine("No s'ha introduït cap valor.");
            }
        }
    }
}
