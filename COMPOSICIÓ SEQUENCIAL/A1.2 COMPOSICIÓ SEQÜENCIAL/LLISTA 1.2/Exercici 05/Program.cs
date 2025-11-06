namespace Exercici_05
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per demanar una lletra pel teclat i mostrar el seu codi ASCII a la pantalla.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletra;
            int codiAscii;
            Console.WriteLine("Escriu una lletra que vulguis convertir a codi ASCII: ");
            lletra = Convert.ToChar(Console.ReadLine());
            codiAscii = (char)(lletra);
            Console.WriteLine($"La lletra {lletra} té assignat el nombre {codiAscii} al codi Ascii");
        }
    }
}
