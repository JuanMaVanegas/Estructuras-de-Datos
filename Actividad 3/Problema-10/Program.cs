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
                63102C / 239 - 2A */

            int vacunas=1000,vacunas1=1000,vacunas2=1000;
            int suma_V1=0,suma_V2=0,suma_V=0;
            
            Console.WriteLine("\nPuesto No.1");
            do{
                Console.WriteLine("\nIngrese la cantidad de vacunas a entregar");
                int cant = int.Parse(Console.ReadLine());
                if (cant<=1000){
                    vacunas = vacunas - cant;
                    suma_V = suma_V + cant;
                    Console.WriteLine($"Quedan {vacunas} vacunas ");
                }
                else{
                    Console.WriteLine($"Solo se tienen {vacunas} vacunas, ingrese una cantidad correcta ");
                    cant = int.Parse(Console.ReadLine());
                    vacunas = vacunas - cant;
                    suma_V = suma_V + cant;
                    Console.WriteLine($"Quedan {vacunas} vacunas ");
                }
            } while (vacunas >= 200 );

            Console.WriteLine("\nEl inventario de vacunas bajo de 200, se cuenta con " + vacunas +" vacunas");
            Console.WriteLine("Cantidad de vacunas entregadas en el puesto No.1: " + suma_V);

            Console.WriteLine("\nPuesto No.2");
            do{
                Console.WriteLine("\nIngrese la cantidad de vacunas a entregar");
                int cant1 = int.Parse(Console.ReadLine());
                if (cant1<=1000){
                    vacunas1 = vacunas1 - cant1;
                    suma_V1 = suma_V1 + cant1;
                    Console.WriteLine($"Quedan {vacunas1} vacunas ");
                }
                else{
                    Console.WriteLine($"Solo se tienen {vacunas1} vacunas, ingrese una cantidad correcta ");
                    cant1 = int.Parse(Console.ReadLine());
                    vacunas1 = vacunas1 - cant1;
                    suma_V1 = suma_V1 + cant1;
                    Console.WriteLine($"Quedan {vacunas} vacunas ");
                }
            } while (vacunas1 >= 200 );

            Console.WriteLine("\nEl inventario de vacunas bajo de 200, se cuenta con " + vacunas1 +" vacunas");
            Console.WriteLine("Cantidad de vacunas entregadas en el puesto No.1: " + suma_V1);

             Console.WriteLine("\nPuesto No.3");
            do{
                Console.WriteLine("\nIngrese la cantidad de vacunas a entregar");
                int cant2 = int.Parse(Console.ReadLine());
                if (cant2<=1000){
                    vacunas2 = vacunas2 - cant2;
                    suma_V2 = suma_V2 + cant2;
                    Console.WriteLine($"Quedan {vacunas2} vacunas ");
                }
                else{
                    Console.WriteLine($"Solo se tienen {vacunas2} vacunas, ingrese una cantidad correcta ");
                    cant2 = int.Parse(Console.ReadLine());
                    vacunas2 = vacunas2 - cant2;
                    suma_V2 = suma_V2 + cant2;
                    Console.WriteLine($"Quedan {vacunas2} vacunas ");
                }      
            } while (vacunas2 >= 200 );

            Console.WriteLine("\nEl inventario de vacunas bajo de 200, se cuenta con " + vacunas2 +" vacunas");
            Console.WriteLine("Cantidad de vacunas entregadas en el puesto No.1: " + suma_V2);

        }
    }
}
