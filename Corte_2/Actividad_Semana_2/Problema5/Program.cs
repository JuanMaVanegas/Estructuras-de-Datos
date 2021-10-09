using System;
using System.Collections;

 /* INTEGRANTES DEL GRUPO:
                Johan Sebastián Ríos
                Luis Esteban Triana
                Juan Manuel Vanegas
                Andrés Santiago Villamil 
            Jornada:
                Diurna
            Grupo:
                63102C / 239 - 2A */

namespace ejercicios_xtrazo
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("PRIMERA LISTA:");
            ArrayList Listnum1 = new ArrayList();
            Listnum1.Add(9);
            Listnum1.Add(11);
            Listnum1.Add(13);
            Listnum1.Add(15);
            Listnum1.Add(17);

            imprime(Listnum1);

            Console.WriteLine("SEGUNDA LISTA:");
            ArrayList Listnum2 = new ArrayList();
            Listnum2.Add(10);
            Listnum2.Add(12);
            Listnum2.Add(14);
            Listnum2.Add(16);
            Listnum2.Add(18);

            imprime(Listnum2);

            
            Console.WriteLine("LA CONCATENACION DE LAS LISTAS ES: ");
            Listnum1.AddRange(Listnum2);
            imprime(Listnum1);

        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int nums in arreglo)
            {
                Console.Write(" {0} ", nums);
                Console.WriteLine("\n");
            }
        }
    }
}
