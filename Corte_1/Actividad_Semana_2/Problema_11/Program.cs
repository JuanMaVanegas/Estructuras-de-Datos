using System;

namespace Problema11
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
            63102C / 239-2A */
            int a=0,b=0,c=0,d=0;
            double  resul=0.00f,resul1=0.00f,resul2=0.00f;
            
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Servicios publicos");
            Console.WriteLine("Ingrese valor del agua");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor del luz");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor del gas");
            c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor del gas");
            d = Int32.Parse(Console.ReadLine());
            if (d==1)
            {
                resul = a - (a * 0.2);
                resul1 = b - (b * 0.2);
                resul2 = c - (c * 0.2);
                Console.WriteLine("Debe pagar de agua {0}",resul);
                Console.WriteLine("Debe pagar de luz {0}",resul1);
                Console.WriteLine("Debe pagar de gas {0}",resul2);
            }
            if (d==2)
            {
                resul = a - (a * 0.15);
                resul1 = b - (b * 0.15);
                resul2 = c - (c * 0.15);
                Console.WriteLine("Debe pagar de agua {0}",resul);
                Console.WriteLine("Debe pagar de luz {0}",resul1);
                Console.WriteLine("Debe pagar de gas {0}",resul2);
            }
            if (d>=3)
            {
                resul = a - (a * 0.9);
                resul1 = b - (b * 0.9);
                resul2 = c - (c * 0.9);
                Console.WriteLine("Debe pagar de agua {0}",resul);
                Console.WriteLine("Debe pagar de luz {0}",resul1);
                Console.WriteLine("Debe pagar de gas {0}",resul2);
            }

        }
    }
}
