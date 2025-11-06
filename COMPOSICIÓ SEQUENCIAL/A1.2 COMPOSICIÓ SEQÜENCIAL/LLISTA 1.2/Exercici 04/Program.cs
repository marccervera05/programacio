namespace Exercici_04
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que demani per teclat dos valors corresponents als coeficients a i b d’una equació de 
        /// primer grau(ax + b = 0) i ens calculi la solució de l’equació.El programa després de demanar els dos valors, 
        /// ens ha de mostrar l’equació i la solució mostrant els coeficients a i b així com la solució exactament amb 
        /// dues xifres decimals.No cal considerar el cas a = 0;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Defineix la variable a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ara defineix la variable b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            x = -b / a;
            Console.WriteLine($"El resultat de l'equació de primer grau (ax + b = 0), on has definit a amb el valor de {a} i b" +
                $"amb el valor de {b}, té com a resultat: {x}!");
        }
    }
}
