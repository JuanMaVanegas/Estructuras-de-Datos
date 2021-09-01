using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*INTEGRANTES DEL GRUPO:
                Johan Sebastian Rios
                Luis Esteban Triana
                Juan Manuel Vanegas
                Andres Santiago Villamil 
            Jornada:
                Diurna
            Grupo:
                63102C / 239 - 2A */
                
            // Problema 1:Escribe un programa que lea un número e imprime un triángulo de números.

            int i, p,espacio,num;
            Console.WriteLine("Ingrese un numero para crear una piramide de numeros: ");
            p= Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= p; i++)
            {
               
                for (espacio = 0; espacio < p ; espacio++)
                {
                    Console.Write(" ");
                }
                for (num = 0; num < i  ; num++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write("");
                    }
                    Console.Write(i);
                }
                Console.WriteLine();
            }
               
            Console.ReadKey();
        }
    }
}
