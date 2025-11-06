using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_11
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer BONUS3.TXT per al càlcul del BONUS. La primera línia del fitxer conté el nombre total de bitllets.Cada línia només informa de si 
        /// el bitllet té un "BONUS" o no. Si la línia té un "BONUS", la següent línia contindrà el valor "BONUS", i en cas contrari, "NO BONUS". Fes un programa 
        /// que processi un fitxer de dades que contingui línies de “BONUS/NO BONUS” en el format indicat i informi de quants bonus s'han distribuït, quants 
        /// bitllets hi apareixen en el fitxer i quin percentatge de bitllets guanyadors hi ha respecte al total.Ha d’indicar també quin és el guany obtingut amb 
        /// els bonus trobats al fitxer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "BONUS3.TXT";
            StreamReader srBonus = new StreamReader(FILENAME);
            int totalBitllets, bitlletsBonus, i;
            double guanyTotal;
            string tipus, lineaNoBonus;
            totalBitllets = Convert.ToInt32(srBonus.ReadLine());
            bitlletsBonus = 0;
            guanyTotal = 0;
            for (i = 1; i <= totalBitllets; i++)
            {
                tipus = srBonus.ReadLine();
                if (tipus == "BONUS")
                {
                    double valorBonus = Convert.ToDouble(srBonus.ReadLine());
                    guanyTotal = guanyTotal + valorBonus;
                    bitlletsBonus = bitlletsBonus + 1;
                }
                else
                    lineaNoBonus = tipus;
            }
            srBonus.Close();
            double percentatgeBonus = (double)bitlletsBonus / totalBitllets * 100;
            Console.WriteLine($"Total de bitllets: {totalBitllets}");
            Console.WriteLine($"Bitllets amb BONUS: {bitlletsBonus}");
            Console.WriteLine($"Guany total amb BONUS: {guanyTotal:0.00}€");
            Console.WriteLine($"Percentatge de bitllets guanyadors: {percentatgeBonus:0.00}%");
        }
    }
}
