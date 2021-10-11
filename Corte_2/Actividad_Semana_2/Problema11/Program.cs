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
                Console.WriteLine("Ingrese un numero flotante:");
                float Num = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 0 para agregar mas numeros");
                Console.WriteLine("Ingrese 9 para salir");
                Salida = int.Parse(Console.ReadLine());
                P.Add(Num);
            }
            Imprimirlista(P);              
        }
        static void Imprimirlista(ArrayList Lista)
        {
            Console.WriteLine("Los numeros de la lista son:");
            foreach (float n in Lista)
            {
                Console.Write($" {n} |");
            }
        }        
    }
}
