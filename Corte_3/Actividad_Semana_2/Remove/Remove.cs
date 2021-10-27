using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "Bienvenido usaremos Remove()";
            String E = S.Remove(0,11);
            
            Console.WriteLine("Estas es la cadena:");
            Console.WriteLine(S);
            Console.WriteLine("Al usar Remove()");
            Console.WriteLine(E);
            
        }
              
    }
}

