using System;

namespace Problema7_Act5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[3,3];
            int estratoFamilia1, estratoFamilia2, estratoFamilia3;
            //double totalFamilia1;

            Console.WriteLine("Digite el estrato de la familia 1");
            estratoFamilia1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del agua para la familia 1:");
            matriz[0, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del gas para la familia 1:");
            matriz[0, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del luz para la familia 1:");
            matriz[0, 2] = Convert.ToDouble(Console.ReadLine());
            
            if (estratoFamilia1 == 1)
            {
                matriz[0, 0] = matriz[0, 0] * 0.2;
                matriz[0, 1] = matriz[0, 1] * 0.2;
                matriz[0, 2] = matriz[0, 2] * 0.2;
            }
            else if (estratoFamilia1 == 2)
            {
                matriz[0, 0] = matriz[0, 0] * 0.15;
                matriz[0, 1] = matriz[0, 1] * 0.15;
                matriz[0, 2] = matriz[0, 2] * 0.15;
            }
            else if (estratoFamilia1 >= 3)
            {
                matriz[0, 0] = matriz[0, 0] * 0.09;
                matriz[0, 1] = matriz[0, 1] * 0.09;
                matriz[0, 2] = matriz[0, 2] * 0.09;
            }
            else
            {
                Console.WriteLine("Numero no valido");
            }

            Console.WriteLine("Digite el estrato de la familia 2");
            estratoFamilia2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del agua para la familia 2:");
            matriz[1, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del gas para la familia 2:");
            matriz[1, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del luz para la familia 2:");
            matriz[1, 2] = Convert.ToDouble(Console.ReadLine());

            if (estratoFamilia2 == 1)
            {
                matriz[1, 0] = matriz[1, 0] * 0.2;
                matriz[1, 1] = matriz[1, 1] * 0.2;
                matriz[1, 2] = matriz[1, 2] * 0.2;
            }
            else if (estratoFamilia2 == 2)
            {
                matriz[1, 0] = matriz[1, 0] * 0.15;
                matriz[1, 1] = matriz[1, 1] * 0.15;
                matriz[1, 2] = matriz[1, 2] * 0.15;
            }
            else if (estratoFamilia2 >= 3)
            {
                matriz[1, 0] = matriz[1, 0] * 0.09;
                matriz[1, 1] = matriz[1, 1] * 0.09;
                matriz[1, 2] = matriz[1, 2] * 0.09;
            }           
            else
            {
                Console.WriteLine("Numero no valido");
            }

            Console.WriteLine("Digite el estrato de la familia 3");
            estratoFamilia3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del agua para la familia 3:");
            matriz[2, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del gas para la familia 3:");
            matriz[2, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor del recibo del luz para la familia 3:");
            matriz[2, 2] = Convert.ToDouble(Console.ReadLine());

            if (estratoFamilia2 == 1)
            {
                matriz[2, 0] = matriz[2, 0] * 0.2;
                matriz[2, 1] = matriz[2, 1] * 0.2;
                matriz[2, 2] = matriz[2, 2] * 0.2;
            }
            else if (estratoFamilia2 == 2)
            {
                matriz[2, 0] = matriz[2, 0] * 0.15;
                matriz[2, 1] = matriz[2, 1] * 0.15;
                matriz[2, 2] = matriz[1, 2] * 0.15;
            }
            else if (estratoFamilia2 >= 3)
            {
                matriz[2, 0] = matriz[2, 0] * 0.09;
                matriz[2, 1] = matriz[2, 1] * 0.09;
                matriz[2, 2] = matriz[2, 2] * 0.09;
            }
            else
            {
                Console.WriteLine("Numero no valido");
            }
            Console.WriteLine(" ");
            Console.WriteLine("ORDEN: AGUA - GAS - LUZ");
            Console.WriteLine("Familia 1:");
            for (int j = 0; j != 3; j++)
            {
                Console.Write($"{matriz[0, j]} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Familia 2: ");
            for (int j = 0; j != 3; j++)
            {
                Console.Write($"{matriz[1, j]} ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Familia 3:");
            for (int j = 0; j != 3; j++)
            {
                Console.Write($"{matriz[2, j]} ");
            }
            Console.ReadKey();
        }
    }
}
