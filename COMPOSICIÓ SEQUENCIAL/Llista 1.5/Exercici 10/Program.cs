using System.Threading;

namespace Exercici_10
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa on llancem un dau de 6 cares (valors de forma aleatoria) fins que el número de vegades que surti 1 i 6 sigui 
        /// el mateix.Conta quantes vegades hem llançat el dau i quantes vegades ha aparegut el valor 6. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random aleatori = new Random();
            int contador1 = 0;
            int contador6 = 0;
            int totalLlançaments = 0;
            int valor = 0;
            Console.WriteLine("Simulació de llançament de dau (aleatori 1-6).");   
            while (contador1 != contador6 || ///!
            {
                valor = aleatori.Next(1, 7);
                totalLlançaments++;
                Console.WriteLine($"Llançament {totalLlançaments}: ha sortit {valor}");
                if (valor == 1)
                    contador1++;
                else if (valor == 6)
                    contador6++;
            }
            Console.WriteLine($"Total de llançaments: {totalLlançaments}, les vegades que ha sortit 1: {contador1} i les vegades que ha sortit 6: {contador6}");
        }
    }
}
