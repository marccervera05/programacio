namespace Exercici_02
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que et demani la teva edat i et digui quants anys faràs l'any vinent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int edat, edatAnyVinent;
            Console.WriteLine("Quants anys tens? ");
            edat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            edatAnyVinent = edat + 1;
            Console.WriteLine($"L'any vinent tindràs {edatAnyVinent} anys!");
        }
    }
}
