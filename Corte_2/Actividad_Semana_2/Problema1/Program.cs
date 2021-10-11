using System;
using System.Collections;

/* INTEGRANTES DEL GRUPO:
               Johan Sebastián Ríos
               Luis Esteban Triana
               Juan Manuel Vanegas
               Andrés Santiago Villamil 
           Jornada:
               Diurna
           Grupo:
               63102C / 239 - 2A */
namespace Ejercicios
{
    class Program
    {
             
        static void Main(string[] args)
        {
            ArrayList Numeros = new ArrayList();
            int Salida=0,num;
            do
            {   
                Console.WriteLine("Ingrese numeros enteros");
                Console.WriteLine("Para salir ingrese el 0");
                num = int.Parse(Console.ReadLine()); 
                if(num==0)
                {
                    Salida++;
                }
                else
                {
                    Numeros.Add(num);
                }
            }while(Salida!=1);
            
            foreach(var numeros in Numeros)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}
