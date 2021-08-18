using System;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un caracter");
            Char c;
            string d;
            c = Char.Parse(Console.ReadLine());
            d=(Char.ToString(c));
            if (d=="a" || d=="e" || d=="i" || d=="o" || d=="u" || d=="A" || d=="E" || d=="I" || d=="O" || d=="U"){
                Console.WriteLine( d +" Es una vocal");
            }
            else if (char.IsSymbol(c)){
                Console.WriteLine( c +" Es un simbolo de teclado");
            }
            else if (char.IsLower(c)){
                
                Console.WriteLine( c +" Es una letra miniscula");
            }
            
        }
    }
}
