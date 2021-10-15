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
            Queue Cola1 = new Queue();
            Queue Cola2 = new Queue();
            Queue ColaResultante = new Queue();
            
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de las colas: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números flotantes de la Cola P1: ");
                Cola1.Enqueue(double.Parse(Console.ReadLine()));
                Console.Write("Digite los números flotantes de la Cola P2: ");
                Cola2.Enqueue(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nCola P1");

            foreach (var n in Cola1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nCola P2");

            foreach (var n in Cola2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            while (Cola1.Count > 0 && Cola2.Count > 0){
                ColaResultante.Enqueue( Cola1.Dequeue() ) ;
                ColaResultante.Enqueue( Cola2.Dequeue() ) ;
            }

            Console.WriteLine("\nAl apilar las Colas P1 y P2");
            foreach (var n in ColaResultante)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
