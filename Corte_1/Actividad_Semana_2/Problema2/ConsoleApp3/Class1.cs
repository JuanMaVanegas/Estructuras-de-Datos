using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 2.Crear un programa que pida 10 diferentes números (positivos o negativos),
/// evaluar la cantidad de números pares e impares.Realizar la suma de cada grupo y su promedio
/// INTEGRANTES DEL GRUPO:
/*      Johan Sebastian Rios
        Luis Esteban Triana
        Juan Manuel Vanegas
        Andres Santiago Villamil 
          Jornada:
                Diurna
           Grupo:
                63102C / 239 - 2A */
namespace FuncionValorAbsoluto
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, conteoneg = 0, sumapos = 0, sumaneg = 0, conteopos = 0, prom = 0, prom2 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese los numeros");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    sumapos += num;
                    conteopos++;
                }
                else
                {
                    sumaneg += num;
                    conteoneg++;
                }
            }
            prom = sumaneg / conteoneg;
            prom2 = sumapos / conteopos;
            Console.WriteLine("La cantidad de numeros positivos ingresados es: {0}", conteopos);
            Console.WriteLine("La cantidad de numeros negativos ingresados es: {0}", conteoneg);
            Console.WriteLine("La suma de los numeros positivos  es: {0}", sumapos);
            Console.WriteLine("La suma de los numeros negativos es: {0}", sumaneg);
            Console.WriteLine("El promedio de los numeros negativos es: {0}", prom);
            Console.WriteLine("El promedio de los numeros positivos  es: {0}", prom2);

        }
    }
}



