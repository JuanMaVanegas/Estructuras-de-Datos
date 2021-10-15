using System;
using System.Collections;

namespace Problema9
{
    class Program
    {
        /*INTEGRANTES DEL GRUPO:
            Johan Sebastian Rios
            Luis Esteban Triana
            Juan Manuel Vanegas
            Andres Santiago Villamil 
        Jornada:
            Diurna
        Grupo:
            63102C / 239 - 2A*/
        static void Main(string[] args)
        {
            Queue ColaP = new Queue();
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de la Cola: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números enteros de la Cola P: ");
                ColaP.Enqueue(int.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine("\nCola P");

            foreach (int n in ColaP)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nCopia Cola P");
            
            
            foreach (int n in ColaP)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
