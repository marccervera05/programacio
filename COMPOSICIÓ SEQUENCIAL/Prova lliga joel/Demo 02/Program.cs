namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linia;
            linia = Console.ReadLine();
            while (linia != null)
            {
                Console.WriteLine($"Hola, {linia}");
                linia = Console.ReadLine();
            }
        }
    }
}
