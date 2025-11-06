namespace Exercici_12
{
    internal class Program
    {
        /// <summary>
        /// Donat el fitxer alumnesDAMDAW.txt, realitza el següent: Llegeix el fitxer i digues si hi ha més alumnes que es diuen 
        /// Alex, o hi ha més alumnes que es diuen Iker.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "alumnesDAMDAW.txt";
            const string MF = null;
            StreamReader sR = new StreamReader(FILENAME);
            int comptadorAlex, comptadorIker;
            comptadorAlex = 0;
            comptadorIker = 0;
            string linia;
            linia = sR.ReadLine();
            while (linia != MF)
            {
                linia = linia.ToUpper();
                if (linia == "ALEX")
                    comptadorAlex = comptadorAlex + 1;
                else if (linia == "IKER")
                    comptadorIker = comptadorIker + 1;
                linia = sR.ReadLine();
            }
            sR.Close();
            if (comptadorAlex > comptadorIker)
                Console.WriteLine($"Hi ha més alumnes que es diuen Alex. {comptadorAlex} Alex i {comptadorIker} Ikers");
            else if (comptadorIker > comptadorAlex)
                Console.WriteLine($"Hi ha més alumnes que es diuen Iker. {comptadorIker} Ikers i {comptadorAlex} Alex");
            else
                Console.WriteLine($"Hi ha el mateix nombre d'alumnes que es diuen Alex i Iker. {comptadorAlex} Alex i {comptadorIker} Ikers");
        }
    }   
}
