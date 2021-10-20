using System;
using System.Collections;

namespace Ejercicios
{
    class Program
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
            int Salida=0;
            Queue P = new Queue();
            while( Salida!=9)
            {
                Console.WriteLine("Ingrese un numero");
                int Num = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 0 para agregar mas numeros");
                Console.WriteLine("Ingrese 9 para salir");
                Salida = int.Parse(Console.ReadLine());
                P.Enqueue(Num);
            }
            Console.WriteLine("Lista 1");
            Imprimirlista(P);
            
            Queue Cola = new Queue();
            while (P.Count > 0){
                Cola.Enqueue( P.Dequeue() ) ;
            }
            Console.WriteLine("Lista 2");
            Imprimirlista(Cola);
            P.Clear();              
        }
        static void Imprimirlista(Queue Lista)
        {
            Console.WriteLine("Los numeros de la lista son:");
            foreach (int n in Lista)
            {
                Console.WriteLine(n);
            }
        }        
    }
}
