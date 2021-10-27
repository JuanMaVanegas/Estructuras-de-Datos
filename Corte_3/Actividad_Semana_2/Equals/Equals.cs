using System;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            String S = "Bienvenido usaremos Equals()";
            String E = "Bienvenido usaremos Equals()";
            String B = "Hola";
            Console.WriteLine("Estas son las cadenas:");
            Console.WriteLine(" Cadena 1: {0}",S);
            Console.WriteLine(" Cadena 2: {0}",E);
            Console.WriteLine(" Cadena 3: {0}",B);
            if(String.Equals(S,E)==true)
            {
                Console.WriteLine("Son iguales las cadenas 1 y 2");
            }
            if(String.Equals(S,B)==true)
            {
                Console.WriteLine("Son iguales las cadenas 1 y 3");
            }
            else
            {
                Console.WriteLine("No son iguales las cadenas 1 y 3");
            }
        }
              
    }
}

