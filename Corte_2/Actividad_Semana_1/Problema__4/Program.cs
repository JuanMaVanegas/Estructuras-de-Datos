using System;

namespace Problema4
{
    class Program
    {
        int[,] matriz = new int [5,5];
           
        public void Guardar_Matriz()
        {
            for (int F=0; F<5;F++)
            {
                for (int C =0; C<5;C++)
                {
                    Console.WriteLine($"Ingrese numero {F+1},{C+1} de la matriz: ");
                    matriz[F,C] = int.Parse(System.Console.ReadLine());
                }
            }
        }
        public void Imprimir_Matriz ()
        {
            Console.WriteLine("la matriz es:");
            for (int F=0; F<5;F++)
            {
                for (int C =0; C<5;C++)
                {
                    Console.Write("  ["+matriz[F,C]+"]  ");
                }
                Console.WriteLine();
            }
        }
        public void Inversa_Matriz ()
        {
            Console.WriteLine("La inversa es:");
            Console.WriteLine("  ["+matriz[0,0]+"]    ["+matriz[1,0]+"]    ["+matriz[2,0]+"]    ["+matriz[3,0]+"]    ["+matriz[4,0]+"]  ");
            Console.WriteLine("  ["+matriz[0,1]+"]    ["+matriz[1,1]+"]    ["+matriz[2,1]+"]    ["+matriz[3,1]+"]    ["+matriz[4,1]+"]  ");
            Console.WriteLine("  ["+matriz[0,2]+"]    ["+matriz[1,2]+"]    ["+matriz[2,2]+"]    ["+matriz[3,2]+"]    ["+matriz[4,2]+"]  ");
            Console.WriteLine("  ["+matriz[0,3]+"]    ["+matriz[1,3]+"]    ["+matriz[2,3]+"]    ["+matriz[3,3]+"]    ["+matriz[4,3]+"]  ");
            Console.WriteLine("  ["+matriz[0,4]+"]    ["+matriz[1,4]+"]    ["+matriz[2,4]+"]    ["+matriz[3,4]+"]    ["+matriz[4,4]+"]  ");
            
        }
        static void Main(string[] args)
        {
            Program Matriz = new Program();
            Matriz.Guardar_Matriz();
            Matriz.Imprimir_Matriz();
            Matriz.Inversa_Matriz();
        }
    }
}
