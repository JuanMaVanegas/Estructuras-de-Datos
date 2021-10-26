using System;

namespace PadRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMetodo PadRight()");
            Console.WriteLine("Por favor ingrese una cadena ");
            string Cadena = Console.ReadLine();

            Console.WriteLine("\nPadRight (Int32)");
            Console.Write("|");
            Console.Write(Cadena.PadRight(25));
            Console.WriteLine("|");       

            char x = '.';
            Console.WriteLine("\nPadRight (Int32, Char)");
            Console.WriteLine(Cadena.PadRight(16, x));  
            Console.WriteLine("");
            Console.WriteLine("");   
            
        }
    }
}
