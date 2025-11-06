using System.Diagnostics;

namespace Exercici_14
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer BONUS2.TXT per al càlcul del BONUS. Quan apareix la paraula "BONUS", a continuació hi ha la quantitat guanyada 
        /// a la següent línia. Si es troba "NO BONUS", no hi ha cap quantitat associada. Processa el fitxer per identificar les línies amb 
        /// "BONUS" i extreure les quantitats de cada BONUS. Finalment, calcula el total dels guanys i el nombre de bitllets amb BONUS.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "BONUS2.TXT";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            string linia, liniaImport;
            int bitlletsBonus, totalGuanys, importBonus;
            bitlletsBonus = 0;
            totalGuanys = 0;
            linia = sR.ReadLine();
            while (linia != MF)
            {
                linia = linia.ToUpper();
                if (linia == "BONUS")
                {
                    bitlletsBonus = bitlletsBonus + 1;
                    liniaImport = sR.ReadLine();
                    if (liniaImport != MF)
                    {
                        importBonus = Convert.ToInt32(liniaImport);
                        totalGuanys = totalGuanys + importBonus;
                    }
                }
                linia = sR.ReadLine();
            }
            sR.Close();
            Console.WriteLine($"Nombre de bitllets amb BONUS: {bitlletsBonus} i un total de guanys: {totalGuanys} €");
        }
    }
}
