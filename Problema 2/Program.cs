using System;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promoción de compra llevate 3 peliculas y paga las 2 más baratas");
            double P1;
            double P2;
            double P3;
            double Tpagar;

            Console.WriteLine("Ingrese el precio de la pelicula");
            P1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de la pelicula");
            P2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de la pelicula");
            P3 = double.Parse(Console.ReadLine());
            if (P1 > P2 && P1 > P3)
            {
                Tpagar = P2 + P3;
                Console.WriteLine("Total a pagar por las 3 peliculas: " + Tpagar);
            }
            else if (P2 > P1 && P2 > P3)
            {
                Tpagar = P1 + P3;
                Console.WriteLine("Total a pagar por las 3 peliculas: " + Tpagar);
            }
            else
            {
                Tpagar = P2 + P1;
                Console.WriteLine("Total a pagar por las 3 peliculas: " + Tpagar);
            }
        }
    }
}
