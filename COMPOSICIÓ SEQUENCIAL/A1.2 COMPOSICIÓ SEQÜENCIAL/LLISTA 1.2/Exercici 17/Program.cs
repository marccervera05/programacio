namespace Exercici_17
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que et demani el nombre de cares d'un dau i després llença el dau 
        /// aleatòriament(suposa que el dau està numerat començant per 1).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int caresDau, valorDau;
            Random r = new Random();
            Console.WriteLine("Quantes cares té el teu dau? ");
            caresDau = Convert.ToInt32(Console.ReadLine());
            valorDau = r.Next(1, caresDau+1);   ///Li he sumat 1 a les cares del cau ja que sinó el randomitzador no conta 
                                                ///l'interval com a interval tancat. (Si el dau té 2 cares sempre surt 1).
            Console.WriteLine($"Del dau amb {caresDau} cares ha sortit el següent valor: {valorDau}!");
        }
    }
}
