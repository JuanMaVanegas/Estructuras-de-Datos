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
            ArrayList Numeros = new ArrayList();
            Random ale = new Random();
            Numeros.Add(ale.Next(1,100));
            
            Imprimirlista(Numeros);
            Cuadradolista(Numeros);
            Sumatoria(Numeros);
        }
        static void Imprimirlista(ArrayList Lista)
        {
            Console.WriteLine("Los numeros de la lista es:");
            foreach (int n in Lista)
            {
                Console.WriteLine(n);
            }
        }
        static void Cuadradolista(ArrayList Lista)
        {
            Console.WriteLine("El cuadrado de la lista es:");
            foreach(int n in Lista)
            {
                Console.WriteLine(" {0} ", n*n);
            }
        }
        static void Sumatoria(ArrayList Lista)
        {
            Console.WriteLine("La sumatoria de los cuadrados es:");
            int Suma=0;
            foreach (int n in Lista)
            {
                Suma= Suma + (n*n);
                Console.WriteLine(Suma);
            }
        }
    }
}
