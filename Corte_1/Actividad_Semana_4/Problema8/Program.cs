using System;

namespace Problema8
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
            int num,j,Mayor=0,Menor=0;
            double num1,Prome,Suma=0;
            Console.WriteLine("Ingrese numero de personas");
            num = Int32.Parse(Console.ReadLine());
            for (j=1;j<=num;j++)    
            {
                Console.WriteLine("Ingrese altura de la persona {0}",j);
                num1 = double.Parse(Console.ReadLine());
                Suma +=  num1;
                Prome= Suma/num;
                if (num1>Prome)
                {
                    Mayor=Mayor+1;
                }
                if (num1<Prome)
                {
                    Menor=Menor+1;
                }
            }
            Console.WriteLine("Personas mayor al promedio: {0}",Mayor);
            Console.WriteLine("Personas menor al promedio: {0}",Menor);
        }
    }
}
