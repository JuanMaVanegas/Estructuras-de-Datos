using System;

namespace Problema4
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
            // Problema 4:Crea un array de números de 100 posiciones, que contendrá los números del 1 al 100.
            // Obtén la suma de todos ellos y la media del array

             int [] numeros =new int[101];
            int suma = 0;
            Console.WriteLine("Array de numeros: ");
            for (int contador = 1; contador <numeros.Length; contador++)
            {
                System.Console.WriteLine(contador + numeros[contador]);
            }
                for (int contador = 1; contador < numeros.Length; contador++)
                {
                    suma += contador+numeros[contador];
                }
                Console.WriteLine("La suma del array: " + suma);
            float media = suma / numeros.Length;
            Console.WriteLine("La media del array: " + media);
        }
    }
}
