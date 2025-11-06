namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS2.TXT. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS2.TXT";
            int numero, suma, comptador;
            suma = 0;
            comptador = 0;
            double mitjana;
            using StreamReader sR = new StreamReader(FILENAME);
            string linia; 
            linia = sR.ReadLine();
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                suma += numero;
                comptador++;
                linia = sR.ReadLine();
            }
            if (comptador > 0)
            {
                mitjana = (double)suma / comptador;
                Console.WriteLine($"La mitjana dels {comptador} valors és: {mitjana:F2}");
            }
            else
                Console.WriteLine("No s'ha trobat cap valor al fitxer.");

            sR.Close();
        }
    }
}
