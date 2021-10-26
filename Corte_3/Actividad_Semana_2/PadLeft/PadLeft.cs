using System;

namespace PadLeft
{
    class PadLeft
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
            Console.WriteLine("\nMetodo PadLeft()");

            Console.WriteLine("Por favor ingrese una cadena: ");
            string Cadena = Console.ReadLine();

            Console.WriteLine("\nPadLeft (Int32)");
            Console.WriteLine(Cadena.PadLeft(18));

            char x = '.';
            Console.WriteLine("\nPadLeft (Int32, Char)");   
            Console.WriteLine(Cadena.PadLeft(16, x));
            Console.WriteLine(""); 

        }
    }
}
