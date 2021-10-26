using System;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMetodo Replace()");

            String Nombres = "Juan Pedro Jose Maria Jorge Yuliana";
            Console.WriteLine("\nString Original: {0} ", Nombres);
            Console.WriteLine("String Reemplazado: {0} ", Nombres.Replace(' ', ',').Replace("Juan", "Leidy").Replace("Jose", "Alberto"));
            
            Console.WriteLine("\nDigite una cadena");
            string Cadena = Console.ReadLine();

            Console.WriteLine("\nString Original:\n {0} ", Cadena);
            Console.WriteLine("\nString Reemplazado:\n {0}",Cadena.Replace(" ", "-...-"));
            Console.WriteLine("");
        }
    }
}
