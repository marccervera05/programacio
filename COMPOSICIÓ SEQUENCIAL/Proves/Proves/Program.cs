namespace Proves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg;
            double x = 45.5;
            int a = 2; int b = 3;
            int tiradaDau;
            Console.Write("VALOR DE LA TIRADA DAU:");
            tiradaDau = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"T'HA TOCAT {tiradaDau * 10} EUROS!");
            Console.WriteLine
            ($"VALOR de a -->: {a} EL DOBLE VAL {a * 2} I {a} ELEVAT A 2 VAL {Math.Pow(a, 2)}");
            Console.Write("ENTRA UN MISSATGE -->");
            msg = Console.ReadLine();
            Console.WriteLine($"EL TEU MISSATGE ÉS {msg}");
            Console.WriteLine(x);
            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Round(x));
            Console.WriteLine(Math.Ceiling(Math.Pow(x, 3)));
            Console.WriteLine($"HOLA {msg}");
        }
    }
}