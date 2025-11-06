namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule el producte del número 1 al numero entrat per l’usuari. ENTRA UN NÚMERO: 4, 24 //1*2*3*4 
        /// NOTA: El producte d’un número...es coneix amb el nom del factorial.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int factorial, numero;
            Console.Write("Entra un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {numero} és: {factorial}");
        }
    }
}
