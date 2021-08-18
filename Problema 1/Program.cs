using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Vb,Va;
            Console.WriteLine("Digite un numero para saber su valor absoluto");
            Va=float.Parse(Console.ReadLine());
            if (Va>0){
                Console.WriteLine("El valor absoluto de "+Va+" es igual a "+Va);
            }
            else if(Va<=0){
                Vb=Va*-1;
                Console.WriteLine("El valor absoluto de "+Va+" es igual a "+Vb);
            }
            
            

        }
    }
}
