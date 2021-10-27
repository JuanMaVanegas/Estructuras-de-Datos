using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "Bienvenido usaremos Insert()";
            String E = S.Insert(0,"Hola, ");
            
            Console.WriteLine("Estas es la cadena:");
            Console.WriteLine(S);
            Console.WriteLine("Al usar Insert()");
            Console.WriteLine(E);
            
        }
              
    }
}

