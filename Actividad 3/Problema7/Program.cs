using System;

namespace Problema7
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
            /*Realizar un programa que pida al usuario dos números y una letra: “i” ó “p”. 
             * El programa presentará los números pares (si se pulsó la “p”) ó impares (si se pulsó la “i”) que hay 
             * desde el primer número al segundo que introdujo el usuario. Si se pulsa alguna tecla distinta de “p” ó “i”, el programa 
             * no imprime ningún número.*/

            int num1, num2;
            Console.WriteLine("Por favor ingrese su primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese su segundo numero mayor que el anterior");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor presione la letra 'p' para saber los pares o presione 2 veces la letra 'i' (ii) para impares");
            if (Console.ReadKey().Key == ConsoleKey.P)
            {
                while ( num1 != num2)
                {
                    num1++;
                    if ((num1 % 2) == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(num1);
                    }
                }
            }
            else if (Console.ReadKey().Key == ConsoleKey.I)
            {
                while (num1 != num2)
                {
                    num1++;
                    if ((num1 % 2) != 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(num1);
                    }
                }
            }
        }
    }
}
