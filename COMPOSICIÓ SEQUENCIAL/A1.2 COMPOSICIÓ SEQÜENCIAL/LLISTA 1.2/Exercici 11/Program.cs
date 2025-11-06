namespace Exercici_11
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per calcular la nòmina d'un treballador: L’usuari ens ha d’entrar el nombre total
        /// d'hores treballades, el sou brut per cada hora treballada i el percentatge d'impost aplicat al sou brut total, 
        /// el programa ha d'informar de: sou brut total, retenció d'impostos i sou net (sou brut menys els impostos).

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
            souBrut = totalHoresTreballades * eurosPerHora;
            retencioImpostos = souBrut * (percentatgeRetencio/100);
            souNet = souBrut - retencioImpostos;
            Console.WriteLine($"La teva nòmina dàquest mes per haver treballat {totalHoresTreballades} hores" +
                $" i amb una retenció d'impostos del {percentatgeRetencio:f2}% equival a: {souBrut:f2}€ bruts, que una vegada" +
                $"aplicada la retenció de {retencioImpostos:f2}€ es converteix en {souNet:f2}€ nets.");
        }
    }
}
