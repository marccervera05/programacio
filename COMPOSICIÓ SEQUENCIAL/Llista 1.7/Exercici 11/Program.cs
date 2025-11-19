namespace Exercici_11
{
    internal class Program
    {
        /// <summary>
        /// Al riu Ebre sospitem que el peix Silur (Silurus glanis) està en perill d’extinció.
        /// Considerarem que el Silur està en perill si en algun tram hi ha 0 silurs
        /// o bé si la suma total de silurs en tots els trams és menor que 10.
        /// Es demana llegir les dades d’un fitxer i informar si està en perill o no.
        /// (Fitxers NOPERILL.TXT, PERILL1.TXT i PERILL2.TXT)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string solucio;
            Console.WriteLine("Defineix quin fitxer vols llegir (entra 'a', 'b' o 'c'): ");
            Console.WriteLine("a -> NOPERILL.TXT");
            Console.WriteLine("b -> PERILL1.TXT");
            Console.WriteLine("c -> PERILL2.TXT");
            solucio = Console.ReadLine();
            Console.Clear();

            if (solucio == "a")
            {
                Console.WriteLine("Has escollit la versió a! (Fitxer NOPERILL.TXT)");
                const string FILENAME = "NOPERILL.TXT";
                ComprovaPerill(FILENAME);
            }
            else if (solucio == "b")
            {
                Console.WriteLine("Has escollit la versió b! (Fitxer PERILL1.TXT)");
                const string FILENAME = "PERILL1.TXT";
                ComprovaPerill(FILENAME);
            }
            else if (solucio == "c")
            {
                Console.WriteLine("Has escollit la versió c! (Fitxer PERILL2.TXT)");
                const string FILENAME = "PERILL2.TXT";
                ComprovaPerill(FILENAME);
            }
            else
                Console.WriteLine("Ep! Has d'escollir entre 'a', 'b' o 'c'.");
        }

        /// <summary>
        /// Aquesta funció comprova si el Silur està en perill d’extinció segons les dades d’un fitxer.
        /// Està en perill si algun tram té 0 silurs o la suma total és menor que 10.
        /// </summary>
        /// <param name="fitxer">Nom del fitxer a llegir</param>
        public static void ComprovaPerill(string fitxer)
        {
            StreamReader srSilurs = new StreamReader(fitxer);
            string linia;
            linia = srSilurs.ReadLine();
            int silurs;
            silurs = 0;
            int suma;
            suma = 0;
            bool perill;
            perill = false;
            while (linia != null)
            {
                silurs = Convert.ToInt32(linia);
                if (silurs == 0)
                    perill = true;
                suma = suma + silurs;
                linia = srSilurs.ReadLine();
            }
            srSilurs.Close();
            if (perill || suma < 10)
                Console.WriteLine("EL SILUR ESTÀ EN PERILL D'EXTINCIÓ");
            else
                Console.WriteLine("EL SILUR NO ESTÀ EN PERILL D'EXTINCIÓ");
        }
    }
}
