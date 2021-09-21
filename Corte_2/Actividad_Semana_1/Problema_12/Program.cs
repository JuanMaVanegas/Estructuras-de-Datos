using System;

namespace Problema_11
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

            int[,] Matriz = new int[12,12];
            int Fila;
            int Columna;

            Console.Write("\nMatriz Original\n      ");
            for(Columna = 0; Columna < 12; Columna++) {
            Console.Write("   " + Columna + "  ");
            }
            Console.WriteLine();
            
            Console.Write("    ┌");
            for(Columna = 0; Columna < 12; Columna++) {
            Console.Write("──────");
            }
            Console.WriteLine("┐");

            Random numAleatorio = new Random();
            for(Fila = 0; Fila < 12; Fila++) {
                if (Fila>9){
                    Console.Write("  " + Fila + "│");
                }
                else{
                    Console.Write("  " + Fila + " │");
                }
               
                for(Columna = 0; Columna < 12; Columna++) {
                    Matriz[Fila,Columna] = numAleatorio.Next(0, 101);
                    if (Matriz[Fila,Columna] < 10){
                        Console.Write("     "+Matriz[Fila,Columna]);
                    }
                    else if (Matriz[Fila,Columna] == 100){
                        Console.Write("   "+Matriz[Fila,Columna]);
                    }
                    else{
                        Console.Write("    "+Matriz[Fila,Columna]);
                    }
                }
                Console.WriteLine("│");
            }
            Console.Write("    └");
            for(Columna = 0; Columna < 12; Columna++) {
                Console.Write("──────");
            }
            Console.WriteLine("┘");

            int[,] MatrizRotada = new int[12,12];
            int ColumnaR = 11;
            for (Fila = 0; Fila < 12; Fila++) { 
              int FilaR = 0;
              for (Columna = 0; Columna < 12; Columna++) { 
                MatrizRotada[FilaR,ColumnaR] = Matriz[Fila,Columna]; 
                FilaR++;
              } 
              ColumnaR--; 
            }
            
            Console.Write("\nMatriz Rotada con dirección a las manecillas del reloj\n      ");
            for(Columna = 0; Columna < 12; Columna++) {
            Console.Write("   " + Columna + "  ");
            }
            Console.WriteLine();
            
            Console.Write("    ┌");
            for(Columna = 0; Columna < 12; Columna++) {
            Console.Write("──────");
            }
            Console.WriteLine("┐");

            for (Fila = 0; Fila < 12; Fila++) { 
                if (Fila>9){
                    Console.Write("  " + Fila + "│");
                }
                else{
                    Console.Write("  " + Fila + " │");
                }
                for (Columna = 0; Columna < 12; Columna++) { 
                    if (MatrizRotada[Fila,Columna] < 10){
                        Console.Write("     "+MatrizRotada[Fila,Columna]);
                    }
                    else if (MatrizRotada[Fila,Columna] == 100){
                        Console.Write("   "+MatrizRotada[Fila,Columna]);
                    }
                    else{
                        Console.Write("    "+MatrizRotada[Fila,Columna]);
                    }
                }
                Console.WriteLine("│");
            }    
            Console.Write("    └");
            for(Columna = 0; Columna < 12; Columna++) {
                Console.Write("──────");
            }
            Console.WriteLine("┘");
        }
    }
}
