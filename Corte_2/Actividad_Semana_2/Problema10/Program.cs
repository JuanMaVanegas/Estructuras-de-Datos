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
            ArrayList P = new ArrayList();
            P.Add(0.0f);
            P.Add(1.1f);
            P.Add(2.22f);
            P.Add(3.333f);
            ArrayList Pila = new ArrayList();
            Pila.AddRange(P);
            Pila.Reverse();
            
            Imprimirlista(P);
            Imprimirlista(Pila);
        }
        static void Imprimirlista(ArrayList Lista)
        {
            Console.WriteLine("Los numeros de la lista son:");
            foreach (float n in Lista)
            {
                Console.WriteLine(n);
            }
        }        
    }
}
