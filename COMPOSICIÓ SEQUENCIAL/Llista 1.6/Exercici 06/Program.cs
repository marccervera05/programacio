namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat. En acabar el programa ha d’informar de quants números son positius, negatius i zeros
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, nombreEntrat, total, positius, negatius, zero;
            i = 0;
            total = 0;
            positius = 0;
            negatius = 0;
            zero = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Entra un nombre: ");
                nombreEntrat = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (nombreEntrat > 0)
                {
                    positius++;
                    total += nombreEntrat;
                }
                else if (nombreEntrat < 0)
                {
                    negatius++;
                    total += nombreEntrat;
                }
                else
                {
                    zero++;
                    total += nombreEntrat;
                }

            }
            Console.WriteLine($"La suma de tots els nobres que has entrat equival a {total}, dels quals n'hi ha {positius} de positius, " +
                $"{negatius} negatius i {zero} que son zero.");
        }
    }
}
