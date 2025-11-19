using System.Globalization;

namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Un fitxer conté línies amb tripletes PRODUCTE, PREU_UNITARI, UNITATS corresponents a un tiquet de venda.
        /// Els productes rics amb colesterol són aquells que contenen el substring "PIZZ" o la paraula "EMBOTIT".
        /// Rebutjarem la compra si al tiquet hi apareix més d’un producte ric en colesterol.
        /// Si fem la compra, informem de l’import total i, si hi ha un sol producte ric en colesterol, informem quin és.
        /// Si no n’hi ha cap, mostrem "COMPRA SANA".
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "TIQUET.TXT";
            StreamReader srTiquet = new StreamReader(FILENAME);
            string linia;
            string producte;
            double preuUnitari;
            int unitats;
            double importTotal;
            importTotal = 0;
            int comptadorColesterol;
            comptadorColesterol = 0;
            string producteColesterol;
            producteColesterol = "";
            linia = srTiquet.ReadLine();
            while (linia != null)
            {
                producte = linia;
                preuUnitari = Convert.ToDouble(srTiquet.ReadLine(), CultureInfo.InvariantCulture);
                unitats = Convert.ToInt32(srTiquet.ReadLine());
                importTotal = importTotal + (preuUnitari * unitats);
                if (producte.ToUpper().Contains("PIZZ") || producte.ToUpper().Contains("EMBOTIT"))
                {
                    comptadorColesterol++;
                    producteColesterol = producte;
                }
                linia = srTiquet.ReadLine();
            }
            srTiquet.Close();
            if (comptadorColesterol > 1) 
                Console.WriteLine("COMPRA REBUTJADA: massa productes rics en colesterol.");       
            else
            {
                Console.WriteLine($"Import total de la compra: {importTotal:F2} €");

                if (comptadorColesterol == 1)
                    Console.WriteLine($"Atenció: el producte ric en colesterol és '{producteColesterol}'.");
                else
                    Console.WriteLine("COMPRA SANA");
            }
        }
    }
}
