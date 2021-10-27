using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "Bienvenido usaremos Contains()";
            Console.WriteLine("Esta es la cadena:");
            Console.WriteLine(S);
            if(S.Contains("Contains")==true)
            {
                Console.WriteLine("Si contiene la palabra (Contains)");
            }
        }
              
    }
}

