using System;

namespace Problema2
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
                
        private static void GenerarNumeros(int [] ranNum)
        {
            Random numAleatorio = new Random();

            for (int i = 0; i < ranNum.Length; i++)
            {
                ranNum[i] = numAleatorio.Next(0, 9);
            }
        }
        private static void MostrarNumeros(int [] ranNum){
            int suma=0;
            for (int i = 0; i < ranNum.Length; i++)
            {
                Console.WriteLine($" -> El valor de la posición {i} del Array es {ranNum[i]}");
                suma = suma + ranNum[i];
            }
            Console.WriteLine($"\n -> La suma de los números aleatorios es igual a: {suma}");
        }
        static void Main(string[] args)
        {
            int longitudV;
            Console.WriteLine("Ingrese el tamaño del array: ");
            longitudV = int.Parse(Console.ReadLine());
            int [] num = new int [longitudV];

            GenerarNumeros(num);
            MostrarNumeros(num);
        }
    }
}
