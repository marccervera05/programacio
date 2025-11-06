namespace Exercici_03
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons i ens informi 
        /// per la consola del total de temps entrat, convertit tot en segons.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int HORES_SEGONS = 3600;
            const int MINUTS_SEGONS = 60;
            int hores, minuts, segons, segonsTotals;
            Console.Write("Quantes hores? ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Quants minuts? ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Quants segons? ");
            segons = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            segonsTotals = hores * HORES_SEGONS + minuts * MINUTS_SEGONS + segons;
            Console.WriteLine($"El total de convertir {hores} hores, {minuts} minuts i {segons} segons és: {segonsTotals} segons!");
        }
    }
}
