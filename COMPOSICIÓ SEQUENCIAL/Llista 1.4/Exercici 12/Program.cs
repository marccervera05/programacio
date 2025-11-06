using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_12
{
    internal class Program
    {
        /// <summary>
        /// Feu un programa que, a partir d’un any entrat per teclat, t’informi si l’any és de traspàs o no ho és. Un any és de traspàs 
        /// si és divisible per 4 i no ho és per 100, a excepció dels anys divisibles per 400, que també són de traspàs (per exemple 
        /// l’any 2000 va ser de traspàs perquè era divisible per 400 tot i també ser-ho per 100). Comprova si aquest curs conté algun 
        /// any de traspàs! Proposa tu la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int anyEntrat;
            bool anyEsDeTraspas;
            Console.WriteLine("Defineix l'any que vols fer servir per comprovar si és de traspàs o no: ");
            anyEntrat = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            anyEsDeTraspas = ComprovantAnyDeTraspas(anyEntrat);
            if (anyEsDeTraspas)            
                Console.WriteLine($"L'any {anyEntrat} és de traspàs.");           
            else 
                Console.WriteLine($"L'any {anyEntrat} no és de traspàs.");      
        }

        /// <summary>
        /// Aquesta funció serveix per determinar si un any entrat per teclat es o no de traspas (amb les condicions perque aixi sigui)
        /// </summary>
        /// <param name="anyEntrat">La variable conté el valor en un enter de l'any que avaluem entrat per teclat</param>
        /// <returns>La funció retorna un boolea true o false depenent si l'any es o no de traspas (True=any de traspas)</returns>
        public static bool ComprovantAnyDeTraspas(int anyEntrat)
        {
            bool resultat;
            if ((anyEntrat % 4 == 0 && anyEntrat % 100 != 0) || (anyEntrat % 400 == 0))
                resultat = true;
            else
                resultat = false;
                
            return resultat; 
        }
    }
}
