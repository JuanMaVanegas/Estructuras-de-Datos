/* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A */
using System;
using System.Collections;

namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            Queue Numeros = new Queue();
            Queue Cuadrado = new Queue();
            Random ale = new Random();
            
            
            int TamañoA;

            Console.WriteLine("\nDigite el tamaño de la cola: ");
            TamañoA = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Los numeros de la Cola es:");
            for (int x = 0; x < TamañoA; x++)
            {
                Numeros.Enqueue(ale.Next(1,100));
                foreach (var n in Numeros)
                {
                    Console.WriteLine(n);
                }
                Queue queueCopy = new Queue(Numeros.ToArray());
                
                while (Numeros.Count > 0 && queueCopy.Count > 0){
                    Cuadrado.Enqueue((int) Numeros.Dequeue() * (int)queueCopy.Dequeue());
                }
            }
            
            
            Console.WriteLine("\nEl cuadrado de la Cola es:");
            foreach(int n in Cuadrado)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nLa sumatoria de los cuadrados es:");
            int Suma=0;
            foreach (int n in Cuadrado)
            {
                Suma= Suma + (n);
            }
            Console.WriteLine(Suma);
        }
        
            
        
    }
}
