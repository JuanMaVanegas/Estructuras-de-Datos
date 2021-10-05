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
            ArrayList PilaP = new ArrayList();
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de la Pila: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números enteros de la Pila P: ");
                PilaP.Add(int.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine("\nPila P");

            foreach (int n in PilaP)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nCopia Pila P");

            foreach (int n in PilaP)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
