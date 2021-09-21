using System;

namespace Problema_10
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

 
            int[,] Matriz = new int[6,10];

            int Fila;
            int Columna;
        
            int Min=100;
            int FilaMin = 0;
            int ColumnaMin = 0;
            
            int Max=0;
            int FilaMax = 0;
            int ColumnaMax = 0;

            Console.Write("\n      ");
            for(Columna = 0; Columna < 10; Columna++) {
              Console.Write("   " + Columna + "  ");
            }
            Console.WriteLine();
            
            Console.Write("    ┌");
            for(Columna = 0; Columna < 10; Columna++) {
              Console.Write("──────");
            }
            Console.WriteLine("┐");
            Random numAleatorio = new Random();
            for(Fila = 0; Fila < 6; Fila++) {
              Console.Write("  " + Fila + " │");
              for(Columna = 0; Columna < 10; Columna++) {
                Matriz[Fila,Columna] = numAleatorio.Next(0, 101);
                if (Matriz[Fila,Columna] < 10){
                  Console.Write("     "+Matriz[Fila,Columna]);
                }
                else if(Matriz[Fila,Columna] == 100){
                  Console.Write("   "+Matriz[Fila,Columna]);
                }
                else{
                  Console.Write("    "+Matriz[Fila,Columna]);
                }
                
                if (Matriz[Fila,Columna] < Min) {
                  Min = Matriz[Fila,Columna];
                  FilaMin = Fila;
                  ColumnaMin = Columna;
                }
                if (Matriz[Fila,Columna] > Max) {
                  Max = Matriz[Fila,Columna];
                  FilaMax = Fila;
                  ColumnaMax = Columna;
                }
              }
              Console.WriteLine("│");
            }
            Console.Write("    └");
            for(Columna = 0; Columna < 10; Columna++) {
              Console.Write("──────");
            }

            Console.WriteLine("┘\n\nEl Máximo es " + Max + " y está en la Fila " + FilaMax + ", Columna " + ColumnaMax);
            Console.WriteLine("El Mínimo es " + Min + " y está en la Fila " + FilaMin + ", Columna " + ColumnaMin+"\n");
      }
    }
}
