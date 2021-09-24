using System;

namespace Problema9_Actiidad5
{
    /*
    INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil
    Jornada:
        Diurna
    Grupo:
        63102C / 239-2A
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marco = new int[5, 15];

            for (int i = 0; i != 15; i++)
            {
                marco[0, i] = 1;
                Console.Write(marco[0,i]);
            }
            Console.WriteLine();
            for (int i = 0; i != 15; i++)
            {
                if(i == 0 || i == 14)
                {
                    marco[1, i] = 1;
                    Console.Write(marco[1, i]);
                }
                else
                {
                    marco[1, i] = 0;
                    Console.Write(marco[1, i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i != 15; i++)
            {
                if (i == 0 || i == 14)
                {
                    marco[2, i] = 1;
                    Console.Write(marco[2, i]);
                }
                else
                {
                    marco[2, i] = 0;
                    Console.Write(marco[2, i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i != 15; i++)
            {
                if (i == 0 || i == 14)
                {
                    marco[3, i] = 1;
                    Console.Write(marco[3, i]);
                }
                else
                {
                    marco[3, i] = 0;
                    Console.Write(marco[3, i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i != 15; i++)
            {
                marco[4, i] = 1;
                Console.Write(marco[4, i]);
            }
            Console.ReadKey();
        }
    }
}
