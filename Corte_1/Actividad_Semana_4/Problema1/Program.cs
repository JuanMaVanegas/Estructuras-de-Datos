using System;

namespace Problema1
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

        private static void Rellenar(int [] ArrayRell){
            for (int i = 0; i < ArrayRell.Length; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                ArrayRell[i] = num;
            }
        }
        private static void Mostrar( int [] ArrayRell){
            Console.WriteLine("\nIngrese el numero con el que desea hacer la multiplicación y la división: ");
            double myd = double.Parse(Console.ReadLine());
            double div;

            for (int i = 0; i <ArrayRell.Length; i++){
            Console.WriteLine($"\n -> El valor de la posición {i} del Array es:   {ArrayRell[i]}");
            double mult = ArrayRell[i]*myd;
                if (myd != 0 ){
                    div = ArrayRell[i]/myd;
                }else{
                    Console.WriteLine("No se puede dividir entre 0");
                    div = 0;
                }
            Console.WriteLine($"\n -> Al multiplicarlo por {myd} es igual a:   {mult}");
            Console.WriteLine($" -> Al dividirlo entre {myd} es igual a:   {div}");
            }
        }
        static void Main(string[] args)
        {
            int longitudV=15;
            int [] Numeros = new int[longitudV];

            Rellenar(Numeros);
            Mostrar(Numeros);
            
        }
    }
}
