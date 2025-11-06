namespace Exercici_15
{
    internal class Program
    {
        /// <summary>
        /// Calcula el canvi d'una quantitat en euros utilitzant la quantitat mínima de monedes. El comerç no accepta 
        /// bitllets de 500€ i 200€. Has de començar amb bitllets de 100€, després 50€, 20€, 10€, 5€, 2€, 1€, 50 cèntims, 
        /// 20 cèntims, 10 cèntims, 5 cèntims, 2 cèntims i 1 cèntim.Suposa que el comerç té canvi il·limitat disponible 
        /// utilitzant bitllets i monedes il·limitats.

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; ///Per poder fer servir la font unicode i escriure €.
            double preuPerPagar, eurosEntregats, canviPerRebre;
            int bitlletsCent, bitlletsCinquanta, bitlletsVint, bitlletsDeu, bitlletsCinc,
                monedesDosEuros, monedesUnEuro, monedesCinquanta, monedesVint, monedesDeu, monedesCinc, 
                monedesDosCentims, monedesUnCentim, auxResidu, totalCentims;
            Console.WriteLine("Quants euros costa el producte/servei que has de pagar? ");
            preuPerPagar = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quants euros li has donat per pagar? ");
            eurosEntregats = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            canviPerRebre = eurosEntregats - preuPerPagar;
            totalCentims = (int)canviPerRebre * 100;
            bitlletsCent = totalCentims / 10000;
            auxResidu = totalCentims % 10000;
            bitlletsCinquanta = auxResidu / 5000;
            auxResidu = auxResidu % 5000;
            bitlletsVint = auxResidu / 2000;
            auxResidu = auxResidu % 2000;
            bitlletsDeu = auxResidu / 1000;
            auxResidu = auxResidu % 1000;
            bitlletsCinc = auxResidu / 500;
            auxResidu = auxResidu % 500;
            monedesDosEuros = auxResidu / 200;
            auxResidu = auxResidu % 200;
            monedesUnEuro = auxResidu / 100;
            auxResidu = auxResidu % 100;
            monedesCinquanta = auxResidu / 50;
            auxResidu = auxResidu % 50;
            monedesVint = auxResidu / 20;
            auxResidu = auxResidu % 20;
            monedesDeu = auxResidu / 10;
            auxResidu = auxResidu % 10;
            monedesCinc = auxResidu / 5;
            auxResidu = auxResidu % 5;
            monedesDosCentims = auxResidu / 2;
            monedesUnCentim = auxResidu % 2;
            Console.WriteLine($"Has pagat {preuPerPagar}€ amb {eurosEntregats}€. T'han de retornar un total de {canviPerRebre}€ " +
                $"repartit de la següent manera: {bitlletsCent} bitllets de cent, {bitlletsCinquanta} bitllets de cinquanta, " +
                $"{bitlletsVint} bitllets de vint, {bitlletsDeu} bitllets de deu, {bitlletsCinc} bitllets de cinc, " +
                $"{monedesDosEuros} monedes de dos euros, {monedesUnEuro} monedes d'un euro, {monedesCinquanta} monedes de " +
                $"cinquanta cèntims, {monedesVint} monedes de vint cèntims, {monedesDeu} monedes de deu cèntims, " +
                $"{monedesCinc} monedes de cinc cèntims, {monedesDosCentims} monedes de dos cèntims i {monedesUnCentim} " +
                $"monedes d'un cèntim");

        }
    }
}
