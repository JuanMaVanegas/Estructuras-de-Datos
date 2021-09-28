using System;

namespace Problema_1
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
            63102C / 239 - 2A*/

        int[,] arreglo = new int[4, 5];
        int[] sumFila = new int[4];
        int[] sumColumna = new int[5];
        int sumaTotalArreglo = 0;

        static void Main(string[] args)
        {
            Program op = new Program();
            op.llenarArreglo();
            op.sumarFila();
            op.sumarColumna();
            op.sumarArreglo();
            op.imprimirArreglo();

        }
        void llenarArreglo()
        {
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    Console.Write("Ingrese un número: ");
                    arreglo[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        void sumarFila()
        {
            int sumaFila;

            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                sumaFila = 0;
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    sumaFila += arreglo[f, c];
                }
                sumFila[f] = sumaFila;

            }
        }

        void sumarArreglo()
        {

            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {

                    sumaTotalArreglo += arreglo[f, c];
                }
            }
        }

        void sumarColumna()
        {
            int sumaColumna;

            for (int f = 0; f < arreglo.GetLength(1); f++)
            {
                sumaColumna = 0;
                for (int c = 0; c < arreglo.GetLength(0); c++)
                {
                    sumaColumna += arreglo[c, f];
                }
                sumColumna[f] = sumaColumna;
            }
        }
        void imprimirArreglo()
        {

            Console.WriteLine();
            for (int f = 0; f < arreglo.GetLength(0); f++)
            {
                for (int c = 0; c < arreglo.GetLength(1); c++)
                {
                    Console.Write($"{arreglo[f, c]}    ");
                }
                Console.Write($" {sumFila[f]}");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < sumColumna.Length; i++)
            {
                Console.Write($"{sumColumna[i]}   ");
            }
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t{sumaTotalArreglo}");
        }
        
    }
}