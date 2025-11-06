namespace Exercici_08
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS.TXT";
            int numero, maxim, minim;
            maxim = 0;
            minim = 0;
            bool primerNumero = true;
            using StreamReader sR = new StreamReader(FILENAME);
            string linia; 
            linia = sR.ReadLine();
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                if (primerNumero)
                {
                    maxim = numero;
                    minim = numero;
                    primerNumero = false;
                }
                else
                {
                    if (numero > maxim)
                        maxim = numero;
                    if (numero < minim)
                        minim = numero;
                }
                linia = sR.ReadLine();
            }
            if (primerNumero)
                Console.WriteLine("No s'ha trobat cap número al fitxer.");
            else
            {
                Console.WriteLine($"El valor més gran és: {maxim} i el més petit és: {minim}");
            }
        }
    }
}
