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

namespace Ejercicio_xtrazo
{
    class Program
    {


        static void ImprimirPilaP(ArrayList Pila)
        {
            foreach (int q in Pila)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("***********************");
        }

        static void ImprimirNuevaPila(ArrayList NPila)
        {
            foreach (int q in NPila)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("**************************");
        }

        static void Main(string[] args)
        {
            String WhileLoop = "";
            do
            {

                int Numero = 0, Cantidad = 0;

                ArrayList PilaP = new ArrayList();
                ArrayList NuevaPila = new ArrayList();

                Console.WriteLine("¿Cuantos datos desea ingresar para la Pila P?");
                Cantidad = int.Parse(Console.ReadLine());

                for (int i = 0; i < Cantidad; i++)
                {
                    Console.Write("- ");
                    Numero = int.Parse(Console.ReadLine());
                    PilaP.Add(Numero);
                }
                
                Console.WriteLine("*******************");
                
                Console.WriteLine($"Hay {PilaP.Count} valores ingresados son estos:");
                ImprimirPilaP(PilaP);

                Console.WriteLine("Los valores de la PilaP seran transpasado a una Nueva Pila");
                Console.WriteLine("****************************");

                foreach (int e in PilaP)
                {
                    NuevaPila.Add(e);
                }

                NuevaPila.Reverse();
                Console.WriteLine("Estos son los valores, impresos invertidamente");
                ImprimirNuevaPila(NuevaPila);



                Console.WriteLine("Ingrese 1 para eliminar los datos de la Pila P, si no quiere salir precione cualquier tecla");
                Console.WriteLine(" SI ELIMINAS LOS DATOS TE VA ARROJAR UN ERROR, AL NO AVER ELEMENTOS EN LA LISTA");
                int Respuesta = 0;
                Respuesta = int.Parse(Console.ReadLine());

                if (Respuesta == 1)
                {
                    PilaP.Clear();

                    Console.WriteLine("");

                    foreach (int c in PilaP)
                    {
                        Console.WriteLine($" [{c}] ");
                    }

                    Console.WriteLine("SE ELIMINARON TODOS LOS ELEMENTOS DE ESTA LISTA P");
                }

                else
                {
                    Console.WriteLine("Decidio no eliminar los datos de la Lista P");
                }

            } while (WhileLoop == "s" || WhileLoop == "S");
            Console.WriteLine("GRACIAS POR USAR EL PROGRAMA, VUELVA PRONTO...");
        }
    }
}
