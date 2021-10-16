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
            Queue Cola1 = new Queue();
            Queue Cola2 = new Queue();
            Queue ColaIntercambio = new Queue();
            
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de las colas: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int x = 0; x < TamañoA; x++)
            {
                Console.Write("Digite los números enteros de la Cola P1: ");
                Cola1.Enqueue(int.Parse(Console.ReadLine()));
                Console.Write("Digite los números enteros de la Cola P2: ");
                Cola2.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nCola P1");

            foreach (var n in Cola1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nCola P2");

            foreach (var n in Cola2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            while (Cola1.Count > 0 ){
                ColaIntercambio.Enqueue( Cola1.Dequeue() );
            }
            while (Cola2.Count > 0){
                Cola1.Enqueue( Cola2.Dequeue());
            }
             while (ColaIntercambio.Count > 0){
                Cola2.Enqueue( ColaIntercambio.Dequeue() );
            }
            
            Console.WriteLine("\nIntercambio Cola P1 con Cola P2");

            foreach (var n in Cola1)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");

            Console.WriteLine("\nIntercambio Cola P2 con Cola P1");

            foreach (var n in Cola2)
                Console.Write($"  [{n}]  ");
            Console.WriteLine("\n-----------");
        }
    }
}
