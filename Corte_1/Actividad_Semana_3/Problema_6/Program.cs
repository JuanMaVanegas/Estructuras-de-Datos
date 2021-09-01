using System;
/*INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
  Jornada:
        Diurna
   Grupo:
        63102C / 239-2A */

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            string entrada;
            
            Console.WriteLine("Numeros pares");
            Console.WriteLine("Ingrese un numero de 100 a 200");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);
                        
            if (a>=100 && a<=200)
            {
                for(b=a;b<=200;b=b+2)
                {
                    Console.WriteLine(b);
                }
            }else
            {
                Console.WriteLine("No ingreso un numero valido");
            }


        }
    }
}
