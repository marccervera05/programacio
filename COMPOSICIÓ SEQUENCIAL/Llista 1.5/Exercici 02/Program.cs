namespace Exercici_02
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa però agafant les dades del fitxer NUMEROS.TXT. FI = null. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS.TXT";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            int valor, nElements;
            string linia;
            nElements = 0;
            linia = sR.ReadLine();
            while (linia != MF)
            {
                valor = Convert.ToInt32(linia);
                nElements = nElements + 1;
                linia = sR.ReadLine();
            }
            Console.WriteLine($"HAN APAREGUT {nElements} VALORS ENTERS");
            sR.Close();
        }
    }
}
