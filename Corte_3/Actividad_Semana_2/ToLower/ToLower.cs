using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "BIENVENIDO USAREMOS TOLOWER()";
            String E = S.ToLower();
            
            Console.WriteLine("Estas es la cadena:");
            Console.WriteLine(S);
            Console.WriteLine("Al usar ToLower()");
            Console.WriteLine(E);
            
        }
              
    }
}

