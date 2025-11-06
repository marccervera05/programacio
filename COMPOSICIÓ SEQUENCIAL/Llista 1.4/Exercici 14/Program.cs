namespace Exercici_14
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per saber si un nombre enter de 4 xifres entrat per teclat és cap-i-cua. Proposa tu la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nombreEntrat;
            bool esCapICua;
            Console.WriteLine("Defineix un nombre de 4 xifres per saber si és o no cap i cua: ");
            nombreEntrat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            esCapICua = VerificarCapICua(nombreEntrat);
            if (esCapICua == true)
                Console.WriteLine($"El nombre {nombreEntrat} és cap i cua.");
            else
                Console.WriteLine($"El nombre {nombreEntrat} no és cap i cua.");
        }

        /// <summary>
        /// Aquesta funció serveix per descomposar un nombre enter de quatre xifres i esmentar si és o no cap i cua amb un booleà
        /// </summary>
        /// <param name="nombreEntrat">Aquesta variable conté l'enter de quatre xifres entrat per teclat</param>
        /// <returns>La funció retorna si el nombre és o no cap i cua</returns>
        public static bool VerificarCapICua(int nombreEntrat)
        {
            bool resultat;
            int milers = nombreEntrat / 1000;               
            int centenes = (nombreEntrat / 100) % 10;       
            int desenes = (nombreEntrat / 10) % 10;         
            int unitats = nombreEntrat % 10;                                                                            
            if (milers == unitats && centenes == desenes)
                resultat = true;
            else
                resultat = false;
            
            return resultat;
        }
    }
}


