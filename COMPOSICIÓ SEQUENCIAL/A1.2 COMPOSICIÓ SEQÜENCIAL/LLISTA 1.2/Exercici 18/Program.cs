namespace Exercici_18
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per mostrar aleatòriament una lletra majúscula.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletra;
            int codiAscii;
            Random r = new Random();
            codiAscii = r.Next(65, 91); ///Ja que les lletres majúscules del codi ASCII tenen aquests valors numèrics.
            lletra = (char)codiAscii;
            Console.WriteLine($"Ha sortit la lletra {lletra}!");
        }
    }
}
