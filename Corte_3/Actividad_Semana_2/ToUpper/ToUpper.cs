using System;

namespace ToUpper
{
    class ToUpper
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
            Console.WriteLine("\nMetodo ToUpper()");
            
            Console.WriteLine("Por favor digite el tamaño del vector:");
            int TamañoCadena= int.Parse(Console.ReadLine());
            
            string [] Cadenas = new string [TamañoCadena];
            string [] MayusculasCad = new string [TamañoCadena];

            Console.WriteLine("\n");
            for (int x = 0; x < TamañoCadena; x ++){
                Console.WriteLine($"Por favor Ingrese la {x+1} cadena");
                Cadenas[x]=Console.ReadLine();
                MayusculasCad[x]= Cadenas[x].ToUpper(); 
            }
            Console.WriteLine("\nCadena Original\t\tCadena en Mayusculas\n");
            for (int x = 0; x < TamañoCadena; x ++){
                Console.WriteLine($"{Cadenas[x]}\t\t---->\t\t{MayusculasCad[x]}");
            }
            Console.WriteLine("");
        }
    }
}
