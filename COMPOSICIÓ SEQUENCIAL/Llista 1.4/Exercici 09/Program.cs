using System;
using System.Drawing;
using System.Numerics;

namespace Exercici_09
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que calculi la nota qualitativa d’un estudiant. Per calcular la nota qualitativa cal tenir en compte 
        /// la nota numèrica de l’examen i la nota numèrica de les pràctiques.Aquestes dues notes seran números reals en el nostre 
        /// programa. Si alguna d'aquestes dues notes és inferior a 3 aleshores la nota qualitativa de l’assignatura és Suspens. 
        /// Altrament es calcula una nota numèrica global agafant el 80% de la nota de l’examen i el 20% de la nota de pràctiques, 
        /// i s’ estableix la nota qualitativa d’acord amb la taula següent: Nota numèrica Nota qualitativa 
        /// Nota< 5 Suspens 5 <= nota < 7 Aprovat 7 <= nota< 9 Notable 9 <= nota < 10 Excel·lent 10 Matrícula d’honor.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double notaExamen, notaPractiques;
            string resultat;
            Console.WriteLine("Quina és la teva nota a l'examen? ");
            notaExamen = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quina és la teva nota de pràctiques? ");
            notaPractiques = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            resultat = NotaQualitativa(notaExamen, notaPractiques);
            Console.WriteLine($"La teva qualificació és: {resultat}.");
        }

        /// <summary>
        /// Aquesta funció serveix per determinar la mitjana ponderada d'un alumne i determinar si ha aprovat i amb quina nota Qualitativa
        /// </summary>
        /// <param name="notaExamen">Conté el valor de la nota de l'examen</param>
        /// <param name="notaPractiques">Conté el valor de la nota de les pràctiques</param>
        /// <returns>La funció retorna la nota numèrica i qualitativa de l'alumne</returns>
        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            double notaFinal = notaExamen * 0.8 + notaPractiques * 0.2;
            string notaQualitativa;
            if (notaExamen < 3 || notaPractiques < 3)
                notaQualitativa = $"Alguna de les notes és inferior a 3.";
            else
                if (notaFinal < 5)
                    notaQualitativa = "Suspens";
                else if ( notaFinal < 7)
                    notaQualitativa = "Aprovat";
                else if (notaFinal < 9)
                    notaQualitativa = "Notable";
                else if ( notaFinal < 10)
                    notaQualitativa = "Excel·lent";
                else
                    notaQualitativa = "Matrícula d’honor";
            return notaQualitativa;
        }
    }
}
