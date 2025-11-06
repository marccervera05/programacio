namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per demanar una lletra minúscula i mostrar la lletra majúscula equivalent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletraMinuscula, lletraMajuscula;
            Console.WriteLine("Entra una minúscula: ");
            lletraMinuscula = Convert.ToChar(Console.ReadLine());
            lletraMajuscula = (char)(lletraMinuscula - 32);
            Console.WriteLine($"{lletraMinuscula} convertida a majúscula = {lletraMajuscula}");
        }
    }
}
