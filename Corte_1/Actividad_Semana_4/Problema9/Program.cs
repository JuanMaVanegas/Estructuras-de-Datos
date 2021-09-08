using System;

namespace Problema9
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
                63102C / 239-2A */
        static void Main(string[] args)
        {
            int num,factorial=1,num1,i,factorial1=1,num2,factorial2=1,j;
            double num4;
            for (j=0;j<=5;j++)    
            {   Console.WriteLine("Ingrese numero mayor posible de loteria");
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero elegido");
                num1 = Int32.Parse(Console.ReadLine());
                if (num>0)
                {    
                    if(num1>0)
                    {   
                        for (i=1;i<=num;i++)
                        {
                            factorial = factorial *i;
                        }
                        for (i=1;i<=num1;i++)
                        {
                            factorial1 = factorial1 *i;
                        }
                        num2=num-num1;
                        for (i=1;i<=num2;i++)
                        {
                            factorial2 = factorial2 *i;
                        }
                        num4 = factorial/(factorial1*factorial2);
                        Console.WriteLine("El numero de apuestas es: {0}",num4);
                    }       
                }
            }  
        }
    }
}
