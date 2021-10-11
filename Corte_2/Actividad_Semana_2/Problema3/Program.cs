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
            Numeros.Add(ale.Next(1,100));
            Numeros.Add(ale.Next(1,100));
            Numeros.Add(ale.Next(1,100));
            Numeros.Add(ale.Next(1,100));
            
            Imprimirlista(Numeros);
            Console.WriteLine("Ingrese el numero");
            int numeros = int.Parse(Console.ReadLine());
            int numero = Numeros.IndexOf(numeros);
            numero++;
            Console.WriteLine("El numero {0} se encuentra en la posicion {1}",numeros,numero);
            
        }
        static void Imprimirlista(ArrayList Lista)
        {
            Console.WriteLine("Los numeros de la lista es:");
            foreach (int n in Lista)
            {
                Console.WriteLine(n);
            }
        }        
    }
}


