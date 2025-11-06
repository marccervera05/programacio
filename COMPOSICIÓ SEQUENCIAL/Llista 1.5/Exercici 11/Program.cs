using System.Diagnostics;
using System.Net;

namespace Exercici_11
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per que faci el següent: 
        /// a.Genera dos nombres entre 1 i 100 a l'atzar. 
        /// b.Ens demana el resultat de la suma, resta, producte i divisió entera. 
        /// c.Si encertem tots els resultats, el programa acaba.
        /// d.Si fallem algun resultat, tornem a repetir des de l'apartat a) fins l'apartat d. .
        /// e.Quan el procés acaba, ens ha d'informar de quantes iteracions han calgut per poder completar correctament les 4 operacions.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random aleatori = new Random();
            int iteracions, num1, num2, sumaUsuari, restaUsuari, producteUsuari, divisioUsuari;
            iteracions = 0;
            bool correcte;
            correcte = false;
            while (!correcte)
            {
                iteracions = iteracions + 1;
                num1 = aleatori.Next(1, 101);
                num2 = aleatori.Next(1, 101);
                Console.WriteLine($"Nombres generats: {num1} i {num2}");
                Console.Write("Suma: ");
                sumaUsuari = Convert.ToInt32(Console.ReadLine());
                Console.Write("Resta: ");
                restaUsuari = Convert.ToInt32(Console.ReadLine());
                Console.Write("Producte: ");
                producteUsuari = Convert.ToInt32(Console.ReadLine());
                Console.Write("Divisió entera: ");
                divisioUsuari = Convert.ToInt32(Console.ReadLine());
                correcte = sumaUsuari == (num1 + num2) && restaUsuari == (num1 - num2) && producteUsuari == (num1 * num2) && divisioUsuari == (num1 / num2);
                Console.Clear();
                if (correcte)
                    Console.WriteLine("Tots els resultats són correctes!");
                else
                    Console.WriteLine("Alguna resposta és incorrecta. Provem amb altres nombres...");
            }
            Console.WriteLine($"Has necessitat {iteracions} iteracions per completar correctament les 4 operacions.");
        }
    }
}


