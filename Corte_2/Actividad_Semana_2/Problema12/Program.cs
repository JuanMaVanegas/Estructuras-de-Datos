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
            int Salida=0;
            ArrayList P = new ArrayList();
            while( Salida!=9)
            {
                Console.WriteLine("Ingrese un numero");
                int Num = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 0 para agregar mas numeros");
                Console.WriteLine("Ingrese 9 para salir");
                Salida = int.Parse(Console.ReadLine());
                P.Add(Num);
            }
            Console.WriteLine("Lista 1");
            Imprimirlista(P);
            
            ArrayList Pila = new ArrayList();
            Pila.AddRange(P);
            Console.WriteLine("Lista 2");
            Imprimirlista(Pila);
            P.Clear();              
        }
        static void Imprimirlista(ArrayList Lista)
        {
            Console.WriteLine("Los numeros de la lista son:");
            foreach (int n in Lista)
            {
                Console.WriteLine(n);
            }
        }        
    }
}
