using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "Bienvenido usaremos Copyto()";
            char[] e = new char [10];
            S.CopyTo(0,e,0,10);
            Console.WriteLine("Esta es la cadena que usamos:");
            Console.WriteLine(S);
            Console.WriteLine("Asi es como queda despues de usar Copyto()");
            Console.WriteLine(e);  
        }
              
    }
}

