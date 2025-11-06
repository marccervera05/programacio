namespace VolumEsfera
{
    internal class Program
    {
        /// <summary>
        /// Programa que et demana el radi d'una esfera en metres i et calcula el seu volum (4/3*PI*r*r*r)
        /// Compte que el programa té una errada, la saps trobar?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            double radi, volum;
            Console.Write("Introdueix el radi de l'esfera en metres:");
            radi = Convert.ToDouble(Console.ReadLine());
            volum = 4.0 / 3 * PI * Math.Pow(radi, 3);
            Console.WriteLine($"El volum de l'esfera és: {volum} m3");
        }
    }
}
