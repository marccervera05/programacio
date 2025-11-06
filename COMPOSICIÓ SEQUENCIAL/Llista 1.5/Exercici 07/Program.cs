namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i  el valor més petit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, maxim, minim;
            maxim = 0;
            minim = 0;
            bool primerNumero; 
            primerNumero = true;
            Console.WriteLine("Introdueix números (0 per acabar):");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != 0)
            {
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
                numero = Convert.ToInt32(Console.ReadLine());
            }
            if (primerNumero)
                Console.WriteLine("No s'ha introduït cap número.");
            else
            {
                Console.WriteLine($"El valor més gran és: {maxim} i el més petit és: {minim}");
            }
        }
    }
}
