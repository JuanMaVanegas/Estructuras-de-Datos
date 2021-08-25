using System;

namespace Tarea2
{
    /*
    INTEGRANTES DEL GRUPO:
        Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil
    Jornada:
        Diurna
    Grupo:
        63102C / 239-2A
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[10];
            int opcion=0;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Ingrese un número:");
                    numeros[i] = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("¿Como desea ordenar los numeros? (digite el numero de la opcion):");
                Console.WriteLine("Opcion 1 - De menor a mayor");
                Console.WriteLine("Opcion 2 - De mayor a menor");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo sentimos, esa no es una opción valida. Por favor digite numeros enteros");
            }

            if (opcion == 1)
            {
                Array.Sort(numeros);
                Console.WriteLine("\nLos números ordenados de menor a mayor son:");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            if (opcion == 2)
            {
                Array.Sort(numeros);
                Array.Reverse(numeros);
                Console.WriteLine("\nLos números ordenados de mayor a menor son:");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            Console.ReadKey();
            
            //----------------------------------------------------------------------------------------------------------------------

            
        }
    }
}
