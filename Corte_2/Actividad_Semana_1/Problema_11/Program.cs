using System;

namespace Problema_12
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
            
            int num_conductores,indice_dias=7,x,i,Suma=0;
            int[,] Kms = new int[10000000,8];
            int[] Suma_Kms = new int[10000000];
            string[] Dias = new string[7]{"Lunes","Martes","Miércoles","Jueves","Viernes","Sábado","Domingo"};

            Console.WriteLine("¿Cuántos conductores tiene la empresa?:");
            num_conductores = int.Parse(Console.ReadLine());
            
            string[] Nombre = new string[num_conductores];       
            
            Console.WriteLine("");
            for (i=0;i<num_conductores;i++){
                Console.WriteLine("Introduce el nombre del conductor");
                Nombre[i]= Console.ReadLine();
            }
            
            for(x=0;x<num_conductores;x++){
                Console.WriteLine("\nNombre del conductor "+Nombre[x]+":");
                Suma=0;
                for(i=0;i<7;i++){
                    Console.Write( "¿Cuántos km ha realizado el "+Dias[i]+"?:");
                    Kms[i,indice_dias]=int.Parse(Console.ReadLine());
                    Suma = Suma + Kms[i,indice_dias];
                }
                Suma_Kms[x]=Suma;
            }
            Console.WriteLine("");
            for(x=0;x<num_conductores;x++){
                Console.WriteLine(Nombre[x]+" ha realizado "+Suma_Kms[x]+" kms.");
            }
            Console.WriteLine("\n");
        }
    }
}
