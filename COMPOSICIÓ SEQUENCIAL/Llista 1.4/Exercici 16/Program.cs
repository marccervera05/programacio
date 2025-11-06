namespace Exercici_16
{
    internal class Program
    {
        /// <summary>
        ///  L'antiga raça de Gulamatu està molt avançada en el seu esquema de càlcul d'anys. Entenen què és l'any de traspàs (Un any que és divisible 
        /// per 4 i no divisible per 100 amb l'excepció que els anys que són divisibles per 400 també són anys de traspàs.) i també anys de festa 
        /// similars.Un és el festival Huluculu(succeeix en anys divisibles per 15) i el festival Bulukulu(succeeix en anys divisibles per 55 sempre 
        /// que també sigui un any de traspàs). Amb un any hauràs d'indicar quines propietats tenen aquests anys. Si l'any no és un any de traspàs ni 
        /// un any de festival, imprimiu la línia "Aquest és un any normal". L'ordre d'impressió (si n'hi ha) de les propietats és any de traspàs-->huluculu-->bulukulu.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int any;
            bool traspas, hulu, bulu;
            Console.Write("Entra un any ");
            any = Convert.ToInt32(Console.ReadLine());
            traspas = EsAnyTraspas(any);
            hulu = EsAnyFestivalHulukulu(any);
            bulu = EsAnyFestivalBulukulu(any);
            if (traspas != true && !hulu )
                Console.WriteLine($"L'any {any} es un any normal");
            else
                if (traspas && !bulu && !hulu)
                Console.WriteLine($"L'any {any} es un any de traspas");
            else
                    if (hulu  && !bulu)
                Console.WriteLine($"L'any {any} es un any huluculu");
            else
                Console.WriteLine($"L'any {any} es un any bulukulu");
        }
        /// <summary>
        /// Aquesta funció serveix per mirar si l'any es de traspàs o no
        /// </summary>
        /// <param any="any">La variable conté l'any entrat per teclat</param>
        /// <returns>Retorna si l'any es de traspàs true i si no ho és, false</returns>
        public static bool EsAnyTraspas(int any)
        {
            bool traspas;
            traspas = (0 == any % 4) && (any % 100 != 0) || (0 == any % 400);
            return traspas;
        }
        /// <summary>
        /// Aquesta funció serveix per mirar si l'any es Hulukulu
        /// </summary>
        /// <param any="any">La variable conté l'any entrat per teclat</param>
        /// <returns>Retorna true si es Hulukulu i si no ho és, retorna false</returns>
        public static bool EsAnyFestivalHulukulu(int any)
        {
            bool hulu;
            hulu = 0 == any % 15;
            return hulu;
        }
        /// <summary>
        /// LA funció serveix per mirar si l'any es Bulukulu
        /// </summary>
        /// <param any="any">La variable conté l'any entrat per teclat</param>
        /// <returns>True si es Bulukulu i si no ho és, retorna false</returns>
        public static bool EsAnyFestivalBulukulu(int any)
        {
            bool bulu;
            bulu = 0 == any % 55 && EsAnyTraspas(any);
            return bulu;
        }
    }
}
