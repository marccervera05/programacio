namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que demani un número per teclat. El programa ha de mostrar la taula de multiplicar de l‘1 al 10 del número entrat per teclat. 
        /// ENTRA UN NÚMERO: 2, 2 x 0 = 0, 2 x 1 = 2... 2 x 10 = 20
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, resultat;
            Console.Write("Entra un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n Taula de multiplicar del {numero}:");
            for (int i = 0; i <= 10; i++)
            {
                resultat = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultat}");
            }
        }
    }
}
