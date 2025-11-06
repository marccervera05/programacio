namespace Exercici_19
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani un número enter positiu n i mostri el següent ( exemple per n=4) 1=1, 1+2=3, 1+2+3=6, 1+2+3+4=10
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nombreEntrat, i, j, suma;
            string text;
            Console.Write("Introdueix un número enter positiu: ");
            nombreEntrat = Convert.ToInt32(Console.ReadLine());
            if (nombreEntrat == 0 || nombreEntrat < 0)
                Console.WriteLine("Ep! Has d'introduir un nombre enter positiu, torna-ho a intentar!");
            else
                for (i = 1; i <= nombreEntrat; i++)
                {
                    suma = 0;
                    text = " ";
                    for (j = 1; j <= i; j++)
                    {
                        suma += j;
                        text += j;

                        if (j < i)
                            text += "+";
                    }
                    Console.WriteLine($"{text}={suma}");
                }
        }
    }
}
