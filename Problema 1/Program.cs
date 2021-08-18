using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Valorb,Valor;
            Console.WriteLine("Digite un numero para saber su valor absoluto");
            Valor=float.Parse(Console.ReadLine());
            if (Valor>0){
                Console.WriteLine("El Valor absoluto de "+Valor+" es igual a "+Valor);
            }
            else if(Valor<=0){
                Valorb=Valor*-1;
                Console.WriteLine("El Valor absoluto de "+Valor+" es igual a "+Valorb);
            }
            
            

        }
    }
}
