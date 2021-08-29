using System;

namespace Problema8
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
    class Program
    {
        static void Main(string[] args)
        {
            double NumUno, NumDos;
            string Repeat;
            do
            {
                Console.WriteLine("Por favor digite el primer numero:");
                NumUno = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Por favor digite el segundo numero:");
                NumDos = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"La ecuación es: (x+{NumUno}) (x+{NumDos})");

                //El primer coeficiente en este caso siempre es uno  
                double Coeficiente3 = NumUno * NumDos;
                double Coeficiente2 = (NumUno) + NumDos;
                Console.WriteLine($"Los coeficientes son: 1  {Coeficiente2}  {Coeficiente3}\n");

                Console.WriteLine("Desea probar con otros numeros?: S/N:");
                Repeat = Console.ReadLine();

            } while (Repeat == "s" || Repeat == "S");
        }
    }
}
