using System;

namespace Problema_6
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
        public static void Main (string[] args)
        {
            int NEstudiantes;
            
            Console.WriteLine("Por favor ingrese el número de estudiantes:");
            NEstudiantes=int.Parse(Console.ReadLine());

            int[,] MatrizEstudiantes= new int [NEstudiantes,3];

            for (int Fila = 0; Fila < NEstudiantes; Fila++)
            {
                Console.WriteLine("Estudiante No." + (Fila+1) + ":");
                for (int Columna = 0; Columna < 3; Columna++)
                {
                    Console.Write("Ingrese la calificación No. " +(Columna+1)+" : ");
                    MatrizEstudiantes[Fila, Columna] = int.Parse(Console.ReadLine());
                }
            }

            int[] PromEstudiantes = new int [NEstudiantes];
            int Posicion=0;
            int MayorProm=0;
            for (int Fila = 0; Fila < NEstudiantes; Fila++)
            {
                int SumaCalificaciones = 0;
                for (int Columna = 0; Columna < 3; Columna++)
                {
                    SumaCalificaciones += MatrizEstudiantes [Fila,Columna];
                }
                int Prom = SumaCalificaciones/3;
                PromEstudiantes [Fila]= Prom;
                if (Prom>MayorProm)
                {
                    MayorProm = Prom;
                    Posicion = Fila;
                }
                
            }

            Console.WriteLine();
            
            for (int x = 0; x < PromEstudiantes.Length; x++)
            {
                Console.WriteLine("El promedio del estudiante No. " +(x+1)+ " es : "+ PromEstudiantes[x]);
            }
            Console.WriteLine();

            float Total = 0f;
		    foreach(float calificacion in MatrizEstudiantes){
			    Total += calificacion;
		    }
		    float Promedio = Total / MatrizEstudiantes.Length;
            Console.WriteLine("El promedio del curso es: " + Promedio);
            Console.WriteLine("El estudiante con el mejor promedio es el número " + (Posicion+1) + " con: " + MayorProm);
            Console.WriteLine();
        
        }
    }
}
