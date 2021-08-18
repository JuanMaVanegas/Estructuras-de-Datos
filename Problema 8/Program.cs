using System;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un caracter");
            String d;
            c = Console.ReadLine();

            if (char.IsLower(c)){
                
                Console.WriteLine(c+" Es una letra miniscula");
            }
            else if (char.IsSymbol(c)){
                Console.WriteLine(c+ " Es un símbolo del alfabeto");
            }
            else if (d=="a" || d=="e" || d=="i" || d=="o" || d=="u"){
                d=c;
                Console.WriteLine(c+ " Es una vocal");
            }
        }
    }
}
