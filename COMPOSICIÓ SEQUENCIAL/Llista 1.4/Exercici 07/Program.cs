using System.Diagnostics.Metrics;

namespace Exercici_07
{
    internal class Program
    {
        /// <summary>
        /// En un control de radar de velocitat s'estableixen tres trams de sancions: tram 1 de 80 Km/h a 99 Km/h, (100€ de multa) 
        /// tram 2 de 100 Km/h a 129 Km/h(300€ de multa) tram 3 de 130 Km/h en endavant. (600€ de multa) i retirada de carnet
        /// Informeu a partir de la velocitat(que és de tipus enter), quina sanció tindrà el vehicle. Informeu també en cas que el 
        /// vehicle no tingui sanció.
        /// public static string Sancio(int velocitat) // cal retornar 100€, 300€, 600€+retirada de carnet o bé “sense sanció”

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int velocitat;
            string sancio;
            Console.WriteLine("A quanta velocitat circulaves? (En Km/h) ");
            velocitat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (velocitat < 0)
                sancio = "No pots circular a velocitat negativa, siusplau torna a executar el programa";
            else
                sancio = Sancio(velocitat);
                Console.WriteLine(sancio);
        }

        /// <summary>
        /// Aquesta funcíó serveix per determinar la sanció (també pot ser que no n'hi posi) que se li aplicarà a un conductor en 
        /// funció de la velocitat a la que circulava per el radar
        /// </summary>
        /// <param name="velocitat">Aquesta variable conté el valor en Km/h de la velocitat a la que va el cotxe quan passa per el radar</param>
        /// <returns>La funció retorna si el vehicle tindrà sanció o no i, en cas d'haver-hi sanció, la sanció que rebrà</returns>
        public static string Sancio(int velocitat)
        {
            string sancio;
            if (velocitat < 80)
                sancio = $"Al circular amb el teu vehicle a {velocitat} Km/h, no tens cap sanció, enhorabona!";
            else if (velocitat < 100)
                sancio = $"Ep! Al circular amb el teu vehicle a {velocitat} Km/h, tens una sanció de 100€ de multa.";
            else if (velocitat < 130)
                sancio = $"Ep! Al circular amb el teu vehicle a {velocitat} Km/h, tens una sanció de 300€ de multa.";
            else
                sancio = $"Ep! Al circular amb el teu vehicle a {velocitat} Km/h, tens una sanció de 600€ de multa i retirada de carnet.";
            return sancio;
        }
    }
}
