using System;
using System.Collections;

namespace Problema7
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
            ArrayList PilaResultante = new ArrayList();
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de las Pilas: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números flotantes de la Pila P1: ");
                PilaP1.Add(double.Parse(Console.ReadLine()));
                Console.Write("Digite los números flotantes de la Pila P2: ");
                PilaP2.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nPila P1");

            foreach (var n in PilaP1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nPila P2");

            foreach (var n in PilaP2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            PilaResultante.AddRange(PilaP1);
            PilaResultante.AddRange(PilaP2);

            Console.WriteLine("\nAl apilar las Pilas P1 y P2");

            foreach (var n in PilaResultante)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
