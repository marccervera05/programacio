using System.Runtime.ConstrainedExecution;

namespace Exercici_14
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per mostrar l'hora en format hh:mm:ss a partir d'una quantitat de segons donada
        /// com a entrada.Per exemple, si l'entrada és 4000, la sortida ha de ser 01:04:40.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int SEGONS_HORA = 3600;
            const int SEGONS_MINUTS = 60;
            int segonsEntrada, hores, minuts, segons, auxResidu;
            Console.WriteLine("Quants segons vols passar a format hores:minuts:segons? ");
            segonsEntrada = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            hores = segonsEntrada / SEGONS_HORA;
            auxResidu = segonsEntrada % SEGONS_HORA;
            minuts = auxResidu / SEGONS_MINUTS;
            segons = auxResidu % SEGONS_MINUTS;
            Console.WriteLine($"El resultat de convertir {segonsEntrada} segons a format hora és: {hores}:{minuts}:{segons}");
            
        }
    }
}
