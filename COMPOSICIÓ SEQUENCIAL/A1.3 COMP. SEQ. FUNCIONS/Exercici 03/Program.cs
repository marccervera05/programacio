namespace Exercici_03
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa per demanar una lletra minúscula i mostrar la lletra majúscula equivalent.Per assolir el vostre 
        /// objectiu, cal dissenyar una funció que rebi un caràcter (suposarem que sempre serà una lletra minúscula) i retorni 
        /// el valor de la majúscula corresponent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletraMinuscula, lletraMajuscula;
            Console.WriteLine("Defineix la lletra que vols convertir a majúscula: ");
            lletraMinuscula = Convert.ToChar(Console.ReadLine());
            lletraMajuscula = CanviMajuscula(lletraMinuscula);
            Console.WriteLine($"{lletraMinuscula} convertida a majúscula = {lletraMajuscula}");
    
        }
        
        /// <summary>
        /// Funció per canviar de minúscula donada a una majúscula a travès del codi Ascii.
        /// </summary>
        /// <param name="lletraMinuscula">Aquesta variable conté el char de la lletra mínuscula entrada per teclat</param>
        /// <returns>Et retorna la lletra minúscula entrada convertida a majúscula</returns>
        public static char CanviMajuscula(char lletraMinuscula)
        {
            char lletraMajuscula;
            lletraMajuscula = (char)(lletraMinuscula - 32);
            return lletraMajuscula;
        }
    }
}
