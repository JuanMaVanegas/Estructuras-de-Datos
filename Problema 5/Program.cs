using System;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            Console.WriteLine("Ingrese un numero para calcular su raiz cuadrada");
            double res,num;
            num=float.Parse(Console.ReadLine());
            if (num>=0){
                res = Math.Sqrt(num);
                Console.WriteLine("La raiz cuadrada de "+num+" es "+res);
            }else{
                Console.WriteLine("El número debe ser mayor a 0");
            }
            
        }
    }
}
