namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per convertir "Dolars" a "Euros". El programa ens ha de demanar quants Euros són un dólar, 
        /// i la quantitat de dolars que volem convertir.Feu que es mostri el símbol $ i el símbol € correctament.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double dolars, euros, canviDelMoment;
            Console.OutputEncoding = System.Text.Encoding.UTF8; ///Per activar la font unicode!
            Console.WriteLine("Digues la quantitat de dolars que tens per saber l'equivalència en euros: ");
            dolars = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix el valor del canvi de dolars a euros del moment (si es decimal amb una coma!): ");
            canviDelMoment = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            euros = dolars * canviDelMoment;
            Console.WriteLine($"El resultat de covertir {dolars}$ a euros és: {euros}€");
        }
    }
}
