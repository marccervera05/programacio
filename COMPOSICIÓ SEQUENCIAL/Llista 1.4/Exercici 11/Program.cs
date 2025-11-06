namespace Exercici_11
{
    /// <summary>
    /// Dissenyeu un algorisme que, donat un angle entre -360 i 360 graus, determini en quin quadrant es troba. Proposa tu la funció
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int angleEntrat, quadrant;

            Console.WriteLine("Defineix l'angle del que vols esmentar el quadrant (entre -360 i 360 graus): ");
            angleEntrat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            quadrant = Quadrant(angleEntrat);
            if (quadrant == 0)
                Console.WriteLine("Error, has entrat malament l'angle. Torna-ho a provar!");
            else
                Console.WriteLine($"El quadrant al que pertany l'angle {angleEntrat} és {quadrant} quadrant!");
        }

        /// <summary>
        /// Aquesta funció serveix per definir en quin quadrant s'ubica l'angle entrat per teclat.
        /// </summary>
        /// <param name="angleEntrat">Aquesta variable conté el valor de l'angle entrat per teclat.</param>
        /// <returns>La funció retorna amb un string el quadrant al que s'ubica l'angle entrat.</returns>
        public static int Quadrant(int angleEntrat)
        {
            int quadrant;
            if (angleEntrat < -360 || angleEntrat > 360)
                quadrant = 0; ///És per dona l'error i conservar la funció com a int
            else if (angleEntrat >= 0 && angleEntrat < 90 || angleEntrat <= 0 && angleEntrat > -270)
                quadrant = 1;
            else if (angleEntrat >= 90 && angleEntrat < 180 || angleEntrat <= -270 && angleEntrat > -180)
                quadrant = 2;
            else if (angleEntrat >= 180 && angleEntrat < 270 || angleEntrat <= -180 && angleEntrat > 90)
                quadrant = 3;
            else
                quadrant = 4;
            
            return quadrant;
        }
    }
}
