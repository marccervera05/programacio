using System.Drawing;
using System.Net.Sockets;

namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per calcular la nòmina d'un treballador: L’usuari ens ha d’entrar el nombre total
        /// d'hores treballades, el sou brut per cada hora treballada i el percentatge d'impost aplicat al sou brut total, 
        /// el programa ha d'informar de: sou brut total, retenció d'impostos i sou net (sou brut menys els impostos).
        /// No obstant, has de crear tres funcions. Una funció per calcular el sou brut a partir del sou brut per hora i 
        /// el nombre d’hores treballades, una segona funció per calcular la retenció d’impostos a partir d’un percentatge 
        /// d’ impost aplicat(valor real) i un sou brut i una tercera funció per calcular el sou net a partir de la retenció 
        /// total d'impostos i el sou brut.


        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double totalHoresTreballades, souBrut, souNet, percentatgeRetencio, retencioImpostos, eurosPerHora;
            Console.OutputEncoding = System.Text.Encoding.UTF8; ///Per activar la font unicode!
            Console.WriteLine("Escriu les hores que has treballat: ");
            totalHoresTreballades = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Escriu quants euros cobres per hora treballada: ");
            eurosPerHora = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quina retenció d'impostos (en percentatge) tens? ");
            percentatgeRetencio = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            souBrut = SouBrutTotal(totalHoresTreballades, eurosPerHora);
            retencioImpostos = RetencioImpostos(percentatgeRetencio, souBrut);
            souNet = SouNetTotal(souBrut, retencioImpostos);
            Console.WriteLine($"La teva nòmina dàquest mes per haver treballat {totalHoresTreballades} hores" +
                $" i amb una retenció d'impostos del {percentatgeRetencio:f2}% equival a: {souBrut:f2}€ bruts, que una vegada" +
                $"aplicada la retenció de {retencioImpostos:f2}€ es converteix en {souNet:f2}€ nets.");
        }
        
        /// <summary>
        /// Funció per calcular el sou brut a base del total d'hores treballades i el preu pagat per hora.
        /// </summary>
        /// <param name="totalHoresTreballades">Aquesta variable conté el valor del total d'hores treballades entrades per teclat</param> 
        /// <param name="eurosPerHora">Aquesta variable conté el valor dels euros per hora que paguen a l'usuari.</param>
        /// <returns>Et retorna el sou brut</returns>
        public static double SouBrutTotal(double totalHoresTreballades, double eurosPerHora)
        {
            double souBrutTotal;
            souBrutTotal = totalHoresTreballades * eurosPerHora;
            return souBrutTotal; 
        }

        /// <summary>
        /// Funció per calcular la retenció d'impostos a partir de la funció anterior que ens dona el sou brut, necessari per
        /// saber la quantitat restant del sou un cop aplicada la retenció.
        /// </summary>
        /// <param name="percentatgeRetencio">Aquesta variable conté el percentatge de la retenció de l'usuari</param>
        /// <param name="souBrut">Aquesta variable conté el resultat del sou brut de l'usuari</param>
        /// <returns>Et retorna la retenció d'impostos</returns>
        public static double RetencioImpostos(double percentatgeRetencio, double souBrut)
        {
            double retencioImpostos;
            retencioImpostos = souBrut * (percentatgeRetencio / 100);
            return retencioImpostos;
        }

        /// <summary>
        /// Funció per calcular el sou net a partir de les dos funcions anteriors, necessaries per poder restar la retenció
        /// al sou brut i poder saber el sou net resultant.
        /// </summary>
        /// <param name="souBrut">Aquesta variable conté el resultat del sou brut de l'usuari</param>
        /// <param name="retencioImpostos">Aquesta variable conté el resultat de la retenció d'impostos de l'usuari</param>
        /// <returns>Et retorna el sou net</returns>
        public static double SouNetTotal(double souBrut, double retencioImpostos)
        {
            double souNetTotal;
            souNetTotal = souBrut - retencioImpostos;
            return souNetTotal;
        }

    }
}
