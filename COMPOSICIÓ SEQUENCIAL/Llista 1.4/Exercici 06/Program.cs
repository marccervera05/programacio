namespace Exercici_06
{
    internal class Program
    {
        /// <summary>
        /// Feu un programa que llegeixi (per aquest ordre), nom d’equip local, gols fets per l’equip local, nom d’equip visitant, 
        /// gols fets per l’equip visitant.El programa ha d’informar de qui ha guanyat o bé si han empatat i el número de gols amb 
        /// un missatge de l’estil: “El Girona FC ha guanyat al Barcelona FC amb un resultat de 4 a 1” 
        /// public static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)

        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string nomEquipLocal, nomEquipVisitant, resultat;
            int golsEquipLocal, golsEquipVisitant;
            Console.WriteLine("Quin és el nom de l'equip local?");
            nomEquipLocal = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Quants gols ha fet l'equip local?");
            golsEquipLocal = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quin és el nom de l'equip visitant?");
            nomEquipVisitant = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Quants gols ha fet l'equip visitant?");
            golsEquipVisitant = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            resultat = InformeResultat(nomEquipLocal, golsEquipLocal, nomEquipVisitant, golsEquipVisitant);
            Console.WriteLine(resultat);
        }

        /// <summary>
        /// Aquesta funció serveix per esbrinar quin dels dos equips ha guanyat el partit.
        /// </summary>
        /// <param name="nomEquipLocal">Aquesta variable conté el nom de l'equip local</param>
        /// <param name="golsEquipLocal">Aquesta variable conté els gols que ha fet l'equip local</param>
        /// <param name="nomEquipVisitant">Aquesta variable conté el nom de l'equip visitant</param>
        /// <param name="golsEquipVisitant">Aquesta variable conté els gols que ha fet l'equip visitant</param>
        /// <returns>Retorna el resultat del partit.</returns>
        public static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)
        {
            string resultat;

            if (golsEquipLocal > golsEquipVisitant)
                resultat = $"El {nomEquipLocal} ha guanyat al {nomEquipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            else if (golsEquipLocal == golsEquipVisitant)
                resultat = $"El {nomEquipLocal} ha empatat amb el {nomEquipVisitant} amb un resultat de {golsEquipLocal} a {golsEquipVisitant}";
            else
                resultat = $"El {nomEquipVisitant} ha guanyat al {nomEquipLocal} amb un resultat de {golsEquipVisitant} a {golsEquipLocal}";

            return resultat;
        }
    }
}
