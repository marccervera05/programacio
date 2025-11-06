using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// Demana a l'usuari que introdueixi un número enter (suposarem que l’usuari sempre entra un numero enter de 4 digits) 
        /// i el programa ens ha de dir quant sumen els seus digits.Per exemple, si l’usuari entra 1234 el programa ha de mostrar:
        /// Els digits 1234 sumen 10. Per fer-ho, dissenyeu una funció que rebi un enter (suposarem que l’enter sempre té 4 dígits) 
        /// i que retorni un altre enter corresponent a la suma dels seus digits.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, sumaDeTotsElsDigits;
            Console.WriteLine("Escriu un nombre de 4 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            sumaDeTotsElsDigits = SumaDeTotsElsDigits(numero);
            Console.WriteLine($"La suma del nombre {numero} separat per dígits té com a resultat: {sumaDeTotsElsDigits}");
        }
        
        /// <summary>
        /// Funció que serveix per separar un nombre enter de quatre digits en digits independents i calcular el valor d'aquests sumats.
        /// </summary>
        /// <param name="numero">Aquesta variable conté el valor del nombre enter entrat per teclat</param>
        /// <returns>Et retorna el valor de la suma de tots els digits del nombre entrat</returns>
        public static int SumaDeTotsElsDigits(int numero)
        {
            int sumaDeTotsElsDigits, auxResidu, primerDigit, segonDigit, tercerDigit, quartDigit;
            primerDigit = numero / 1000;
            auxResidu = numero % 1000;
            segonDigit = auxResidu / 100;
            auxResidu = auxResidu % 100;
            tercerDigit = auxResidu / 10;
            quartDigit = auxResidu % 10;
            sumaDeTotsElsDigits = primerDigit + segonDigit + tercerDigit + quartDigit;
            return sumaDeTotsElsDigits;
        }
}
}
