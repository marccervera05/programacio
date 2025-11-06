using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_13
{
    internal class Program
    {
        /// <summary>
        /// Un fitxer anomenat bonus.txt conté una línia per a cada bitllet de loteria venut. Cada línia indica si el bitllet és 
        /// "BONUS" o "NO BONUS". Si la línia és "BONUS", l'import associat és un enter aleatori entre 1€ i 10€. Crea un programa que processi 
        /// aquest fitxer. El programa ha de comptar quants bonus s'han distribuït. També ha de calcular el total de bitllets i el percentatge 
        /// de bitllets guanyadors. El fitxer acaba quan es troba un valor null. També has de calcular el total dels guanys i el nombre de bitllets 
        /// amb BONUS.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "bonus.txt";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            string linia;
            double percentatgeBonus;
            int totalBitllets, bitlletsBonus, totalGuanys, guany;
            totalBitllets = 0;
            bitlletsBonus = 0;
            totalGuanys = 0;
            Random aleatori = new Random();
            linia = sR.ReadLine();
            while (linia != MF)
            {
                totalBitllets = totalBitllets + 1;
                linia = linia.ToUpper();
                if (linia == "BONUS")
                {
                    bitlletsBonus = bitlletsBonus + 1;
                    guany = aleatori.Next(1, 11);
                    totalGuanys = totalGuanys + guany;
                }
                linia = sR.ReadLine();
            }
            sR.Close();
            percentatgeBonus = 0;
            if (totalBitllets > 0)
                percentatgeBonus = (bitlletsBonus * 100.0) / totalBitllets;
            Console.WriteLine($"Total de bitllets: {totalBitllets}, els bitllets amb BONUS: {bitlletsBonus}, el percentatge de BONUS: {percentatgeBonus}% " +
                $"i el total de guanys: {totalGuanys} €");
        }
    }
}
