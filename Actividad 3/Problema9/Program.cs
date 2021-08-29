using System;

namespace Problema9
{
    class Program
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
        static void Main(string[] args)
        {
            double la1, la2, la3;
            Console.WriteLine("Por favor ingrese los datos del triangulo\n");
            Console.WriteLine("Por favor ingrese el primer lado");
            la1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo lado");
            la2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el tercer lado");
            la3 = Convert.ToDouble(Console.ReadLine());

            if (la1 == la2 && la1 == la3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else
            {
                if (la1 == la2 || la1 == la3 || la3 == la2)
                {
                    Console.WriteLine("Es un triangulo isosceles");
                }
                else
                {
                    if (la1 != la2 || la2 != la3 || la3 != la1)
                    {
                        Console.WriteLine("Es un triangulo escaleno");
                    } 
                }
            }
        }
    }
}
