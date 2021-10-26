using System;

namespace PadRight
{
    class PadRight
    {
        /* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A*/
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
