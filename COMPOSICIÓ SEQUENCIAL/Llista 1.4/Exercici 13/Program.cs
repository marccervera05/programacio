namespace Exercici_13
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per saber si un nombre enter de 3 xifres entrat per teclat és cap-i-cua. Proposa tu la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nombreEntrat;
            bool esCapICua;
            Console.WriteLine("Defineix un nombre de 3 xifres per saber si es o no cap i cua: ");
            nombreEntrat = Convert.ToInt32(Console.ReadLine());
            Console.Clear(); 
            esCapICua = VerificarCapICua(nombreEntrat);
            if (esCapICua == true)
                Console.WriteLine($"El nombre {nombreEntrat} és cap i cua.");
            else
                Console.WriteLine($"El nombre {nombreEntrat} no és cap i cua.");
        }


        /// <summary>
        /// Aquesta funció serveix per descomposar un nombre enter de tres xifres i esmentar si es o no cap i cua amb un boolea
        /// </summary>
        /// <param name="nombreEntrat">Aquesta variable conté l'enter de tres xifres entrat per teclat</param>
        /// <returns>La funció retorna si el nombre es o no cap i cua</returns>
        public static bool VerificarCapICua(int nombreEntrat)
        {
            bool resultat;
            int centenes, unitats;
            centenes = nombreEntrat / 100; /// primera xifra
            unitats = nombreEntrat % 10;   /// última xifra
            if (centenes == unitats)
                resultat = true;
            else
                resultat = false;
            
            return resultat;
        }
    }
}
