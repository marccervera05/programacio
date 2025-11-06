using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace Exercici_01
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons i ens informi per la consola 
        /// del total de temps entrat, convertit tot en segons.El càlcul cal fer-lo dissenyant una funció que rebi 3 paràmetres 
        /// enters corresponents a les hores, minuts i segons i ens retorni un valor enter corresponent a la conversió a segons.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hores, minuts, segons, segonsTotals;
            Console.WriteLine("Defineix el nombre d'hores: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix el nombre de minuts: ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Defineix el nombre de segons: ");
            segons = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            segonsTotals = ConversioSegonsTotals(hores, minuts, segons);
            Console.WriteLine($"La conversió de {hores} hores, {minuts} minuts i {segons} segons té com a resultat: {segonsTotals} segons");
        }
        /// <summary>
        /// Funció per calcular la conversió d'hores, minuts i segons a nomès segons.
        /// </summary>
        /// <param name="hores"> Aquesta variable conté el valor de les hores convertides</param>
        /// <param name="minuts">Aquesta variable conté el valor dels minuts convertits</param>
        /// <param name="segons">Aquesta variable conté el valor dels segons sobrants</param>
        /// <param name="segonsTotals"></param>
        /// <returns>Et retorna el total de segons</returns>
        public static int ConversioSegonsTotals(int hores, int minuts, int segons)
        { 
            const int HORES_SEGONS = 3600;
            const int MINUTS_SEGONS = 60;
            int total;
            total = hores * HORES_SEGONS + minuts * MINUTS_SEGONS + segons;
            return total;  
        }
    }
    
    }
