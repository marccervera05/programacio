using System.IO.Enumeration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercici_14
{
    internal class Program
    {
        /// <summary>
        /// Donat el fitxer tiquetsuper.txt, calcular la el preu total de la compra del tiquet. La primera línia del fitxer indica el nombre de 
        /// productes.Després cada producte està format per tres línies(Nom del producte, Quantitat comprada de producte, Preu unitari del producte). 
        /// El programa haurà d’indicar el preu final del tiquet. tiquetsuper.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string FILENAME = "tiquetsuper.txt";
            StreamReader sRTiquetsuper = new StreamReader(FILENAME);
            int i, nArticles;
            double importTiquet, unitatsArticle, preuArticle;
            string descripcioArticle;
            importTiquet = 0;
            nArticles = Convert.ToInt32(sRTiquetsuper.ReadLine());
            for (i = 1; i <= nArticles; i++)
            {
                descripcioArticle = sRTiquetsuper.ReadLine();
                unitatsArticle = Convert.ToDouble(sRTiquetsuper.ReadLine());
                preuArticle = Convert.ToDouble(sRTiquetsuper.ReadLine());
                importTiquet = importTiquet + unitatsArticle * preuArticle;
            }
            sRTiquetsuper.Close();
            Console.WriteLine($"El preu total del tiquet és de {importTiquet:0.00}€");
        }
    }
}
