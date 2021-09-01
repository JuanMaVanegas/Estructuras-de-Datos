using System;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creado por: Juan Manuel Vanegas Tamara
            //Grupo: 239-2A
            //Turno: Diurno
            
            int numero, valor;
            Console.WriteLine("Conjetura de Collatz");
            Console.WriteLine("Por favor ingrese un numero:");
            numero= int.Parse(Console.ReadLine());
            valor = numero;
            while( valor > 1){
                if( valor % 2 == 0){
                    valor = (valor / 2);
                    Console.WriteLine( valor + " " );

                }else{
                valor = (valor* 3 ) + 1; 
                Console.WriteLine( valor + " ");
                }
            }
            Console.WriteLine("El numero "+numero+" tiene como conjetura de Collatz "+valor);
        }
    }
}
