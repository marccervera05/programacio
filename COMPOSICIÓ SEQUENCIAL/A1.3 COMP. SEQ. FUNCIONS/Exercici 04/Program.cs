using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_04
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per convertir "Dolars" a "Euros". El programa ens ha de demanar quant Euros són un dólar, 
        /// i la quantitat de dolars que volem convertir.Feu que es mostri el símbol $ i el símbol € correctament.Per assolir 
        /// el vostre objectiu, cal dissenyar una funció que rebi dos paràmetres: un valor real corresponent a una quantitat en 
        /// euros que cal convertir(qtyEuros) i un segon valor real corresponent a l’equivalència euro/dollar(euro2Dollar). 
        /// La funció ha de retornarl’equvalent de qtyEuros dollars. (suposarem que sempre serà una lletra minúscula) i retorni 
        /// el valor de la majúscula corresponent.
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
            euros = CanviDolarsAEuros(dolars,canviDelMoment);
            Console.WriteLine($"El resultat de covertir {dolars}$ a euros és: {euros}€");
        }
        
        /// <summary>
        /// Funció per calcular el canvi de moneda de dolars a euros a base del preu del dolar del dia.
        /// </summary>
        /// <param name="dolars">Aquesta variable conté el valor dels dolars entrats per teclat</param>
        /// <param name="canviDelMoment">Aquesta variable conté el valor del canvi de dolars a euros del moment que s'ha demanat</param>
        /// <returns>Et retorna els euros equivalents</returns>
        public static double CanviDolarsAEuros(double dolars, double canviDelMoment)
        {
            double canviEuros;
            canviEuros = dolars * canviDelMoment;
            return canviEuros;
        }
    }
}
