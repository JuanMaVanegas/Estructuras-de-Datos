using System;

namespace Problema5
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
                63102C / 239 - 2A*/ 
            // Problema 6: Crea un array de números de un tamaño pasado por teclado, el array contendrá números aleatorios entre
            // 1 y 300 y mostrar aquellos números que acaben en un dígito que nosotros le indiquemos por teclado 
            
            Random Aleatorio = new Random();
            int Comparacion;
            int Dimension = 1;
            int[] Resultado = new int[Dimension];
            int Longitud;

            Console.WriteLine("Ingrese por favor la longitud del array");
            Longitud = int.Parse(Console.ReadLine());
            int[] Numeros = new int[Longitud];

            for (int i = 0; i < Longitud; i++)
            {
                Numeros[i] = Aleatorio.Next(1, 300);
                Console.Write($"{Numeros[i]}  ");

            }

            Console.WriteLine("\nIngrese un digito del 0 al 9 para imprimir los numeros que acaben en este: ");
            Comparacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Se van a mostrar los números termiandos en: " + Comparacion);
            Console.WriteLine("Los números son: ");

            for (int j = 0; j < Longitud; j++)
            {
                if (Numeros[j] % 10 == Comparacion)
                {
                    int indice = 0;
                    Resultado[indice] = Numeros[j];
                    Console.Write($"{Resultado[indice]} - ");
                    indice = indice + 1;
                    Dimension = Dimension + 1;
                }
            }

            Dimension = Dimension - 1;
        }
    }
}
