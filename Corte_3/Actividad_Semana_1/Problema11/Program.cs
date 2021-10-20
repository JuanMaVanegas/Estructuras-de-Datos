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
            Queue C = new Queue();
            Queue Cola = new Queue();
            C.Enqueue(0.0f);
            C.Enqueue(1.1f);
            C.Enqueue(2.22f);
            C.Enqueue(3.333f);

            while (C.Count > 0){
                Cola.Enqueue( C.Dequeue() ) ;
            }
            Console.WriteLine("Los numeros de la lista son:");
            foreach (var n in Cola)
                Console.Write($"  [{n}]  ");         
       }       
    }
}
