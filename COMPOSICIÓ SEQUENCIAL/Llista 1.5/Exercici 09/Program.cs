namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que donat un número enter positiu et digui quantes xifres té. Quina és la condició de final en aquest cas?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero, comptador;
            Console.Write("Introdueix un número enter positiu: ");
            numero= Convert.ToInt32(Console.ReadLine());
            comptador = 0;
            if (numero == 0)
            {
                comptador = 1;
            }
            else
            {
                while (numero > 0)
                {
                    numero = numero / 10;
                    comptador = comptador + 1;
                }
            }
            Console.WriteLine($"El número té {comptador} xifres.");
        }
    }
}

