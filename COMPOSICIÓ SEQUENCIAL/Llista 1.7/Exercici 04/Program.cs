using System.Runtime.ConstrainedExecution;

namespace Exercici_04
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demana un número per teclat i mostra la primera posició a on es troba aquest número en el fitxer NUMEROS.TXT. 
        /// ● Per exemple, si l’usuari entra el número “1” llavors els programa ha de mostrar per pantalla un “4”. La “LINIA 4” és la primera posició de fitxer a on 
        /// apareix el número “1”. 
        /// ● Si el número no es troba a dins del fitxer, el programa ha de mostrar per pantalla un “-1”.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS.TXT";
            string linia;
            int numeroBuscat;
            int valor;
            int posicio;
            bool trobat;
            trobat = false;
            posicio = 0;
            valor = 0;
            linia = "";
            Console.Write("Introdueix el número que vols buscar: ");
            numeroBuscat = Convert.ToInt32(Console.ReadLine());

            StreamReader sr = new StreamReader(FILENAME);
            linia = sr.ReadLine();
            while (linia != null && !trobat)
            {
                posicio++;
                valor = Convert.ToInt32(linia);

                if (valor == numeroBuscat)
                    trobat = true;
                else
                    linia = sr.ReadLine();
            }
            sr.Close();
            if (trobat)
                Console.WriteLine($"El número {numeroBuscat} es troba per primera vegada a la línia {posicio}.");
            else
                Console.WriteLine("-1");    
        }
    }
}
