using System;

namespace Problema10
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
            int a=0,b=0,c=0,d=0,e=0;
            double  resul=0.00f;
            
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Precio del terreno");
            Console.WriteLine("Ingrese ancho del lote");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese largo del lote");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese precio por metro cuadrado");
            c = Int32.Parse(Console.ReadLine());
            d = a * b;
            if (d>=400 && d<500)
            {
                e = (d * c);
                resul = e - (e * 0.1 );
                Console.WriteLine("El precio es: {0}",resul);
            }
            if (d>=500 && d<1000)
            {
                e = (d * c);
                resul = e - (e * 0.17);
                Console.WriteLine("El precio es: {0}",resul);
            }
            if (d>=1000)
            {
                e = (d * c);
                
                resul = e - (e * 0.25);
                Console.WriteLine("El precio es: {0}",resul);
            }
        }
    }
}
