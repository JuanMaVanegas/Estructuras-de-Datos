using System;

namespace Problema5
{
    class Program
    {
        int[,] matriz = new int [2,2];
        int[,] MatriZ = new int [2,2];
        int[,] matriz_Suma = new int [2,2];
           
        public void Guardar_Matriz_1()
        {
            for (int F=0; F<2;F++)
            {
                for (int C =0; C<2;C++)
                {
                    Console.WriteLine($"Ingrese numero {F+1},{C+1} de la matriz 1: ");
                    matriz[F,C] = int.Parse(System.Console.ReadLine());
                }
            }
        }
        public void Imprimir_Matriz_1()
        {
            Console.WriteLine("La matriz es:");
            for (int F=0; F<2;F++)
            {
                for (int C =0; C<2;C++)
                {
                    Console.Write("  ["+matriz[F,C]+"]  ");
                }
                Console.WriteLine();
            }
        }
        public void Guardar_Matriz_2()
        {
            for (int F=0; F<2;F++)
            {
                for (int C =0; C<2;C++)
                {
                    Console.WriteLine($"Ingrese numero {F+1},{C+1} de la matriz 2: ");
                    MatriZ[F,C] = int.Parse(System.Console.ReadLine());
                }
            }
        }
        public void Imprimir_Matriz_2()
        {
            Console.WriteLine("La matriz es:");
            for (int F=0; F<2;F++)
            {
                for (int C =0; C<2;C++)
                {
                    Console.Write("  ["+MatriZ[F,C]+"]  ");
                }
                Console.WriteLine();
            }
        }
        public void Inversa_Matriz_2()
        {   
            Console.WriteLine("La inversa es:");
            Console.WriteLine("  ["+MatriZ[0,0]+"]    ["+MatriZ[1,0]+"]  ");
            Console.WriteLine("  ["+MatriZ[0,1]+"]    ["+MatriZ[1,1]+"]  ");
        } 
        public void Suma()
        {
            matriz_Suma[0,0]= matriz[0,0]+MatriZ[0,0];
            matriz_Suma[0,1]= matriz[0,1]+MatriZ[1,0];
            matriz_Suma[1,0]= matriz[1,0]+MatriZ[0,1];
            matriz_Suma[1,1]= matriz[1,1]+MatriZ[1,1];
            Console.WriteLine("La suma es:");
            Console.WriteLine("  ["+matriz_Suma[0,0]+"]    ["+matriz_Suma[0,1]+"]  ");
            Console.WriteLine("  ["+matriz_Suma[1,0]+"]    ["+matriz_Suma[1,1]+"]  ");
        }      
        static void Main(string[] args)
        {
            Program Matriz = new Program();
            Matriz.Guardar_Matriz_1();
            Matriz.Imprimir_Matriz_1();
            Matriz.Guardar_Matriz_2();
            Matriz.Imprimir_Matriz_2();
            Matriz.Inversa_Matriz_2();
            Matriz.Suma();
        }
    }
}
