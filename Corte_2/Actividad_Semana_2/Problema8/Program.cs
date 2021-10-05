using System;
using System.Collections;

namespace Problema8
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
            ArrayList PilaP1 = new ArrayList();
            ArrayList PilaP2 = new ArrayList();
            ArrayList Intercambio = new ArrayList();
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de las Pilas: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números enteros de la Pila P1: ");
                PilaP1.Add(int.Parse(Console.ReadLine()));
                Console.Write("Digite los números enteros de la Pila P2: ");
                PilaP2.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nPila P1");

            foreach (int n in PilaP1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nPila P2");

            foreach (int n in PilaP2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Intercambio.AddRange(PilaP1);
            PilaP1.AddRange(PilaP2);
            PilaP2.AddRange(Intercambio);

            Console.WriteLine("\nIntercambio Pila P1 con Pila P2");

            foreach (int n in PilaP1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nIntercambio Pila P2 con Pila P1");

            foreach (int n in PilaP2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
