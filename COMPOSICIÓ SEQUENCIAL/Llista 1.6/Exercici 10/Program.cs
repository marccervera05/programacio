namespace Exercici_10
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostri tots els números múltiples de 4 entre el 0 i el 300. Després de mostrar 20 números, el programa ha de pausar-se fins que 
        /// l’usuari premi una tecla. Utilitza la instrucció Console.ReadKey() per esperar que l’usuari entri una tecla.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int comptador = 0;
            for (int i = 0; i <= 300; i += 4)
            {
                Console.Write(i + "\t");
                comptador++;
                if (comptador % 20 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Prem qualsevol tecla per continuar...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nFi del programa!");
        }
    }
}
