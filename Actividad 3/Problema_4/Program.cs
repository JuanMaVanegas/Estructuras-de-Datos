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
            int n,cont;
            double n1=0,n2=0,n3=0,resul=0,a=2,a1=6,fact=0;
            string entrada;
            
            Console.WriteLine("Suma 1 + ⅟2!+ ⅟3!+ ... + ⅟n!");
            Console.WriteLine("Ingrese valor de n");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);
            
            fact = n;
            for (cont=n;cont>1;cont--)
            {
                fact = fact * (cont-1);
            }
            
            n1 = 1 / a;
            n2 = 1 / a1;
            n3 = 1 / fact;
            resul =1+n1+n2+n3;
            Console.WriteLine("El resultado es {0}",resul);
            
        }
    }
}
