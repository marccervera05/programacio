namespace HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que et demani el teu nom i et saludi dient HOLA + El teu nom
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string elteunom;
            Console.Clear();
            Console.Write("Com et dius?");
            elteunom = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hola {elteunom}");
        }
    }
}
